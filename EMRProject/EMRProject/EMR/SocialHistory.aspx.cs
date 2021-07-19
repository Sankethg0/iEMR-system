using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace EMR
{
    public partial class SocialHistory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtHOM.Focus();
            loadSHHistory();


        }
        protected void loadSHHistory()
        {
            string v = Session["smrn"].ToString();
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D8FRGB1\SQLEXPRESS;Initial Catalog=EMRdb;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from Medical_history where patient_id=" + v + " and history_type='SH' ", con);

            int yeartoday = DateTime.Now.Year;
            cmd.ExecuteNonQuery();
            SqlDataReader r = cmd.ExecuteReader();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    if (r.GetValue(1).ToString() == "MarSt" && r.GetValue(2).ToString() == "Married")
                    {
                        ChkMar.Checked = true;
                    }
                    else if (r.GetValue(1).ToString() == "MarSt" && r.GetValue(2).ToString() == "Single")
                    {
                        ChkSin.Checked = true;
                    }
                    if (r.GetValue(1).ToString() == "Smok" && r.GetValue(2).ToString() == "Smoking")
                    {
                        chkSm.Checked = true;
                        if (r.GetValue(3).ToString() == "no note")
                        {
                            txtYears.Text = "";
                        }
                        else
                        {
                            txtYears.Text = r.GetValue(3).ToString();
                        }
                    }
                    else if (r.GetValue(1).ToString() == "Smok" && r.GetValue(2).ToString() == "Non Smoking")
                    {
                        chkNSm.Checked = true;
                    }
                    if (r.GetValue(1).ToString() == "Dru" && r.GetValue(2).ToString() == "Drugs")
                    {
                        chkDru.Checked = true;
                        if (r.GetValue(3).ToString() == "no note")
                        {
                            txtAlFreq.Text = "";
                        }
                        else
                        {
                            txtAlFreq.Text = r.GetValue(3).ToString();
                        }
                    }
                    else if (r.GetValue(1).ToString() == "Dru" && r.GetValue(2).ToString() == "No Drugs")
                    {
                        chkNDru.Checked = true;
                    }
                    if (r.GetValue(1).ToString() == "Alco" && r.GetValue(2).ToString() == "Alcohol")
                    {
                        chkAlc.Checked = true;
                    }
                    else if (r.GetValue(1).ToString() == "Alco" && r.GetValue(2).ToString() == "Non Alcohol")
                    {
                        chkNAlc.Checked = true;
                    }
                }
            }
            if (!r.HasRows)
            {

            }
            con.Close();
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string val = Session["smrn"].ToString();

            string historytype = "SH";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D8FRGB1\SQLEXPRESS;Initial Catalog=EMRdb;Integrated Security=True");
            

            con.Open();
             SqlCommand cmd = new SqlCommand("delete from Medical_history where patient_id=" + val + " and history_type='SH'", con);
            cmd.ExecuteNonQuery();


            con.Close();
            con.Open();

            SqlCommand cmd1 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@history_type)", con);

            cmd1.Parameters.AddWithValue("@patient_id1", val);
            cmd1.Parameters.AddWithValue("@code1", "MarSt");
            string yesorno = "";
            if (ChkMar.Checked)
            {
                yesorno = "Married";
            }
            else if (ChkSin.Checked)
            {
                yesorno = "Single";
            }
            cmd1.Parameters.AddWithValue("@value1", yesorno);
            cmd1.Parameters.AddWithValue("@note1", "no note");
            string d = DateTime.Now.ToString();
            cmd1.Parameters.AddWithValue("@datestamp1", d);
            cmd1.Parameters.AddWithValue("@history_type", historytype);

            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id2,@code2,@value2,@note2,@datestamp2,@history_type)", con);


            cmd2.Parameters.AddWithValue("@patient_id2", val);
            cmd2.Parameters.AddWithValue("@code2", "Smok");

            if (chkSm.Checked)
            {
                yesorno = "Smoking";
                cmd2.Parameters.AddWithValue("@note2", txtYears.Text);
            }
            else if (chkNSm.Checked)
            {
                yesorno = "Non Smoking";
                cmd2.Parameters.AddWithValue("@note2","");
            }
            cmd2.Parameters.AddWithValue("@value2", yesorno);
            

            cmd2.Parameters.AddWithValue("@datestamp2", d);
            cmd2.Parameters.AddWithValue("@history_type", historytype);
            cmd2.ExecuteNonQuery();

           

            SqlCommand cmd4 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id4,@code4,@value4,@note4,@datestamp4,@history_type)", con);

            cmd4.Parameters.AddWithValue("@patient_id4", val);
            cmd4.Parameters.AddWithValue("@code4", "Dru");

            if (chkDru.Checked)
            {
                yesorno = "Drugs";
            }
            else if (chkNDru.Checked)
            {
                yesorno = "No Drugs";
            }
            cmd4.Parameters.AddWithValue("@value4", yesorno);
            cmd4.Parameters.AddWithValue("@note4", "no note");

            cmd4.Parameters.AddWithValue("@datestamp4", d);
            cmd4.Parameters.AddWithValue("@history_type", historytype);

            cmd4.ExecuteNonQuery();

            SqlCommand cmd5 = new SqlCommand("Insert into Medical_history" + "(patient_id,code,value,note,datestamp,history_type)values(@patient_id5,@code5,@value5,@note5,@datestamp5,@history_type)", con);

            cmd5.Parameters.AddWithValue("@patient_id5", val);
            cmd5.Parameters.AddWithValue("@code5", "Alco");

            if (chkAlc.Checked)
            {
                yesorno = "Alcohol";
            }
            else if(chkNAlc.Checked)
            {
                yesorno = "Non Alcohol";
            }
            cmd5.Parameters.AddWithValue("@value5", yesorno);
            cmd5.Parameters.AddWithValue("@note5",txtAlFreq.Text);

            cmd5.Parameters.AddWithValue("@datestamp5", d);
            cmd5.Parameters.AddWithValue("@history_type", historytype);

            cmd5.ExecuteNonQuery();
            con.Close();
            
        }

        protected void txtHOM_TextChanged(object sender, EventArgs e)
        {
            string prev = Session["hom"].ToString();
            if (txtHOM.Text == "HOM" && prev == "DOC")
            {
                txtHOM.Text = "";
                Response.Redirect("DoctorDashboard.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
            }
            if (txtHOM.Text == "HOM" && prev == "MA")
            {
                txtHOM.Text = "";
                Response.Redirect("MADashboard.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
            }
        }
    }
}