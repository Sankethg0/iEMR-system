﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace EMR
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHH45AF\SQLEXPRESS;Initial Catalog=EMRdb;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["hom"] = "MA";
            txtRBMA.Focus();
            if (txtMRN.Text != "")
            {
                PInfo();
                PEmerDet();
                Allergy();
                PMH();
                FH();
                SH();
                addTextBoxCM();
                Images();
                LabReports();
                loadVitals();
            }
            if (txtApCode.Text != "" && txtMRN.Text!="")
            {
                Session["smrn"] = txtMRN.Text;
                Session["sapc"] = txtApCode.Text;
                PI();
                loadVitals();
            }
           else if(txtApCode.Text == "" && txtMRN.Text == "")
            {
                string val1 = Request.QueryString["apc"];
                string val2 = Request.QueryString["mrn"];
                txtApCode.Text = val1;
                txtMRN.Text = val2;
                if (txtApCode.Text != "" && txtMRN.Text != "")
                {
                    PInfo();
                    PEmerDet();
                    Allergy();
                    PMH();
                    FH();
                    SH();
                    addTextBoxCM();
                    PI();
                    Images();
                    LabReports();
                    loadVitals();
                }
                if (txtDOB.Text != "")
                {
                    int yeartoday = DateTime.Now.Year;
                    int byear = int.Parse(txtDOB.Text.Substring(0, 4));
                    int yrs = yeartoday - byear;
                    txtAge.Text = yrs.ToString() + " yrs";
                }
            }


        }
        protected void PMH()
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Medical_history where patient_id=" + txtMRN.Text + " and history_type='PMH' ", con);
            cmd1.ExecuteNonQuery();
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            CheckBoxList2.DataTextField = "code";

            CheckBoxList2.DataSource = dt1;
            CheckBoxList2.DataBind();
            con.Close();
            for (int i = 0; i < CheckBoxList2.Items.Count; i++)
            {
                CheckBoxList2.Items[i].Selected = true;
            }
        }
        protected void Allergy()
        {
           
                con.Open();
                SqlCommand cmd2 = new SqlCommand("select distinct code,note from Medical_history where patient_id=" + txtMRN.Text+ " and history_type='ALL'", con);
                cmd2.ExecuteNonQuery();
                SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                CheckBoxList1.DataTextField = "note";
                CheckBoxList1.DataSource = dt2;
                CheckBoxList1.DataBind();
                con.Close();
                for (int i = 0; i < CheckBoxList1.Items.Count; i++)
                {
                    CheckBoxList1.Items[i].Selected = true;
                }
            
        }
         public void addTextBoxCM()
        {
            con.Open();
            TextBox txt1 = new TextBox();
            txt1.TextMode = TextBoxMode.MultiLine;
            txt1.Width =340;
            txt1.BorderWidth = 0;
            txt1.Font.Bold = true;
            txt1.Attributes.Add("style", "overflow :hidden");
            txt1.ClientIDMode = System.Web.UI.ClientIDMode.Static;
            SqlDataAdapter sda = new SqlDataAdapter("select * from Orders where patient_id=" + txtMRN.Text + " and type='Med'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt1.Rows = dt.Rows.Count;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txt1.Text += dt.Rows[i].ItemArray[2].ToString() + "\n";

            }
            dt.Clear();
            con.Close();
            if (txt1.Text != "")
            {
                addControl.Controls.Add(txt1);
            }
        }
        protected void PI()
        {

            con.Open();
            SqlCommand cmd2 = new SqlCommand("select distinct symptom from PresentIllness where app_code=" + txtApCode.Text, con);
            cmd2.ExecuteNonQuery();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            CheckBoxList5.DataTextField = "symptom";

            CheckBoxList5.DataSource = dt2;
            CheckBoxList5.DataBind();
            con.Close();
            for (int i = 0; i < CheckBoxList5.Items.Count; i++)
            {
                CheckBoxList5.Items[i].Selected = true;
            }

        }
        public void LabReports()
        {
            con.Open();
            TextBox txt1 = new TextBox();
            txt1.TextMode = TextBoxMode.MultiLine;
            txt1.Width = 100;
            txt1.BorderWidth = 0;
            txt1.Font.Bold = true;
            txt1.Style["text-align"] = "center";
            txt1.Attributes.Add("style", "overflow :hidden");
            txt1.ClientIDMode = System.Web.UI.ClientIDMode.Static;
            SqlDataAdapter sda = new SqlDataAdapter("select * from Lab_Reports where patient_id=" + txtMRN.Text + "", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt1.Rows = 2;
            txt1.Text = dt.Rows.Count.ToString() + " Lab Reports";
            dt.Clear();
            con.Close();
            addControlLab.Controls.Add(txt1);
        }
        public void Images()
        {
            con.Open();
            TextBox txt1 = new TextBox();
            txt1.TextMode = TextBoxMode.MultiLine;
            txt1.Width = 100;
            txt1.BorderWidth = 0;
            txt1.Font.Bold = true;
            txt1.Style["text-align"] = "center";
            txt1.Attributes.Add("style", "overflow :hidden");
            txt1.ClientIDMode = System.Web.UI.ClientIDMode.Static;
            SqlDataAdapter sda = new SqlDataAdapter("select * from Images where patient_id=" + txtMRN.Text + "", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt1.Rows = 2;
            txt1.Text = dt.Rows.Count.ToString() + "   Images";
            dt.Clear();
            con.Close();
            addControlImg.Controls.Add(txt1);

        }
        protected void FH()
        {

            con.Open();
            SqlCommand cmd2 = new SqlCommand("select distinct code from Medical_history where patient_id=" + txtMRN.Text + " and history_type='FH'", con);
            cmd2.ExecuteNonQuery();
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            CheckBoxList3.DataTextField = "code";

            CheckBoxList3.DataSource = dt2;
            CheckBoxList3.DataBind();
            con.Close();
            for (int i = 0; i < CheckBoxList3.Items.Count; i++)
            {
                CheckBoxList3.Items[i].Selected = true;
            }

        }
        protected void SH()
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select distinct code,value from Medical_history where patient_id=" + txtMRN.Text + " and history_type='SH' ", con);
            cmd1.ExecuteNonQuery();
            SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            CheckBoxList4.DataTextField = "value";

            CheckBoxList4.DataSource = dt1;
            CheckBoxList4.DataBind();
            con.Close();
            for (int i = 0; i < CheckBoxList4.Items.Count; i++)
            {
                CheckBoxList4.Items[i].Selected = true;
            }
        }
        protected void txtRBMA_TextChanged(object sender, EventArgs e)
        {
            if (txtRBMA.Text.Length > 4)
            {
                if (txtRBMA.Text == "LOGOUT")
                {
                    txtRBMA.Text = "";
                    btnLogOut_Click(sender, e);
                }
                string rbtxt = txtRBMA.Text;
                string key = txtRBMA.Text.Substring(0, 4);
                string des = rbtxt.Substring(4);
                string key1 = txtRBMA.Text.Substring(0, 3);
                string des1 = rbtxt.Substring(3);

                if (key == "MRN ")
                {
                    txtMRN.Text = des;
                    txtRBMA.Text = "";
                }
                else {
                    if (key == "APC ")
                    {
                        txtApCode.Text = des;
                        txtRBMA.Text = "";
                    }
                    else if (key == "VID ")
                    {
                        txtVID.Text = des;
                        txtRBMA.Text = "";
                    }

                    else if (key1 == "BP ")
                    {
                        txtBP.Text = des1;
                        txtRBMA.Text = "";
                    }
                    else if (key == "WEI ")
                    {
                        txtWei.Text = des;
                        txtRBMA.Text = "";
                    }
                    else if (key == "HEI ")
                    {
                        txtHei.Text = des;
                        txtRBMA.Text = "";
                    }
                    else if (key == "PUL ")
                    {
                        txtPulse.Text = des;
                        txtRBMA.Text = "";
                    }

                    else if (key == "TEM ")
                    {
                        txtTemp.Text = des;
                        txtRBMA.Text = "";
                    }
                    else if (key == "PO2 ")
                    {
                        txtPO2.Text = des;
                        txtRBMA.Text = "";
                    }
                    else if (key == "DEL ")
                    {
                        Button3_Click(sender, e);
                        txtRBMA.Text = "";
                    }
                    else if (key == "BMI ")
                    {
                        txtBMI.Text = des;
                        txtRBMA.Text = "";
                    }
                }
            }
            if (txtRBMA.Text.Length == 3)
            {
                string key2 = txtRBMA.Text.Substring(0, 3);
                if (key2 == "PMH")
                {
                    Response.Redirect("PastMedicalHistory.aspx?mrn=" + txtMRN.Text);
                }
                else if(key2 == "ALL")
                {
                    Response.Redirect("Allergy.aspx?mrn="+txtMRN.Text) ;
                }
                else if (key2 == "CLR")
                {
                    txtRBMA.Text = "";
                    Button2_Click(sender, e);

                }
                else if (key2 == "ADD")
                {
                    txtRBMA.Text = "";
                    Button1_Click(sender, e);
                }
                else if (key2 == "IMG")
                {
                    Response.Redirect("Image.aspx");
                }
            }
            if (txtRBMA.Text.Length == 2)
            {
                string key1 = txtRBMA.Text.Substring(0, 2);

                if (key1 == "FH")
                {
                    Response.Redirect("FamilyHistory.aspx");
                }
                if (key1 == "CM")
                {
                    Response.Redirect("CurrentMedications.aspx");
                }
                if (key1 == "PI")
                {
                  Response.Redirect("PresentIllness.aspx");
                }
                if (key1 == "SH")
                {
                   Response.Redirect("SocialHistory.aspx");
                }
                if (key1 == "LR")
                {
                    Response.Redirect("LabReports.aspx");
                }

            }
            if (txtMRN.Text != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Patient where patient_id=" + txtMRN.Text + "", con);
                cmd.ExecuteNonQuery();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    txtPTN.Text = r[2].ToString();
                    txtContact.Text = r[4].ToString();
                    txtEmail.Text = r[5].ToString();
                    txtDOB.Text = r[6].ToString();
                    txtGen.Text = r[7].ToString();
                    txtBGP.Text = r[8].ToString();
                    txtDistrict.Text = r[10].ToString();

                }

                con.Close();
                con.Open();
                SqlCommand cmd2 = new SqlCommand("select * from PatientEmergencyDetails where patient_id=" + txtMRN.Text+ "", con);
                cmd2.ExecuteNonQuery();
                SqlDataReader r2 = cmd2.ExecuteReader();
                while (r2.Read())
                {
                    txtPCP.Text = r2[1].ToString();
                    txtPFX.Text = r2[2].ToString();
                    txtECN.Text = r2[3].ToString();
                }
                con.Close();
                PInfo();
                PEmerDet();
                Allergy();
                PMH();
                FH();
                SH();
                addTextBoxCM();
                LabReports();
                Images();
                loadVitals();
                if (txtDOB.Text != "")
                {
                    int yeartoday = DateTime.Now.Year;
                    int byear = int.Parse(txtDOB.Text.Substring(0, 4));
                    int yrs = yeartoday - byear;
                    txtAge.Text = yrs.ToString() + " yrs";
                }

            }
            if (txtMRN.Text != "" && txtApCode.Text != "")
            {
                PI();
            }
            
            if(txtWei.Text!="" && txtHei.Text != "")
            {
                float wei = float.Parse(txtWei.Text);
                float hei = float.Parse(txtHei.Text);
                float bmi = wei / (hei * hei);
                txtBMI.Text = bmi.ToString();
            }

        }
        protected void loadVitals()
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from Vitals where app_code=" + txtApCode.Text + "", con);
           
            cmd1.ExecuteNonQuery();
            SqlDataReader r1 = cmd1.ExecuteReader();
            if (r1.HasRows)
            {
                while (r1.Read())
                {
                    txtVID.Text = r1[0].ToString();
                    txtBP.Text = r1[2].ToString();
                    txtWei.Text = r1[3].ToString();
                    txtHei.Text = r1[4].ToString();
                    txtPulse.Text = r1[5].ToString();
                    txtTemp.Text = r1[6].ToString();
                    txtPO2.Text = r1[7].ToString();
                    txtMRN.Text = r1[8].ToString();
                    txtBMI.Text = r1[10].ToString();


                }
            }
            if (!r1.HasRows)
            {

            }
            con.Close();
        }
        protected void PEmerDet()
        {
            con.Open();
            SqlCommand cmd3 = new SqlCommand("select * from PatientEmergencyDetails where patient_id=" + txtMRN.Text + "", con);
            cmd3.ExecuteNonQuery();
            SqlDataReader r3 = cmd3.ExecuteReader();
            while (r3.Read())
            {
                txtPCP.Text = r3[1].ToString();
                txtPFX.Text = r3[2].ToString();
                txtECN.Text = r3[3].ToString();
            }
            con.Close();
        }
        protected void PInfo()
        {
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select * from Patient where patient_id=" + txtMRN.Text + "", con);
            cmd2.ExecuteNonQuery();
            SqlDataReader r2 = cmd2.ExecuteReader();
            while (r2.Read())
            {

                txtPTN.Text = r2[2].ToString();
                txtContact.Text = r2[4].ToString();
                txtEmail.Text = r2[5].ToString();
                txtDOB.Text = r2[6].ToString();
                txtGen.Text = r2[7].ToString();
                txtBGP.Text = r2[8].ToString();
                txtDistrict.Text = r2[10].ToString();
            }
            con.Close();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Vitals" + "(vital_id,app_code,bloodpressure,weight,height,pulse,temp,po2,user_id,timestamp,BMI)values(@vital_id,@app_code,@bloodpressure,@weight,@height,@pulse,@temp,@po2,@user_id,@timestamp,@BMI)", con);
            cmd.Parameters.AddWithValue("@vital_id", txtVID.Text);
            cmd.Parameters.AddWithValue("@app_code", txtApCode.Text);
            cmd.Parameters.AddWithValue("@bloodpressure", txtBP.Text);
            cmd.Parameters.AddWithValue("@weight", txtWei.Text);
            cmd.Parameters.AddWithValue("@height", txtHei.Text);
            cmd.Parameters.AddWithValue("@pulse", txtPulse.Text);
            cmd.Parameters.AddWithValue("@temp", txtTemp.Text);
            cmd.Parameters.AddWithValue("@user_id", txtMRN.Text);
            string x = DateTime.Now.ToString();
            cmd.Parameters.AddWithValue("@timestamp",x);
            cmd.Parameters.AddWithValue("@po2", txtPO2.Text);
            cmd.Parameters.AddWithValue("@BMI", txtBMI.Text);
            cmd.ExecuteNonQuery();
            Response.Write(@"<script language='javascript'>alert('Patient Vitals Entered!!!')</script>");
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var nvc = HttpUtility.ParseQueryString(Request.Url.Query);
            nvc.Remove("mrn");
            nvc.Remove("apc");
            string url = Request.Url.AbsolutePath + "?" + nvc.ToString();
            Response.Redirect(url);
            txtVID.Text = "";
            txtApCode.Text = "";
            txtBP.Text = "";
            txtWei.Text = "";
            txtHei.Text = "";
            txtPulse.Text = "";
            txtTemp.Text = "";
            txtMRN.Text = "";
            txtPCP.Text = "";
            txtPFX.Text = "";
            txtECN.Text = "";
            txtPO2.Text = "";
            txtBMI.Text = "";
            txtDistrict.Text = "";
            txtDOB.Text = "";
            txtMRN.Text = "";
            txtGen.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtPTN.Text = "";
            txtBGP.Text = "";
            txtAge.Text = "";
            CheckBoxList1.Items.Clear();
            CheckBoxList2.Items.Clear();
            CheckBoxList3.Items.Clear();
            CheckBoxList4.Items.Clear();
            addControl.Controls.Clear();
            addControlImg.Controls.Clear();
            addControlLab.Controls.Clear();
            CheckBoxList5.Items.Clear();
            Session.Clear();
        }
        
        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from Vitals where app_code=" + txtRBMA.Text.Substring(4) + "", con);
            cmd.ExecuteNonQuery();
            
            Response.Write(@"<script language='javascript'>alert('Patient Vitals Deleted!!!')</script>");
            con.Close();
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Main.aspx");
        }

    }
}   

    
