﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMR
{
    public partial class RoSConstitutional : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtHOM.Focus();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtCons.Text = "CONSTITUTIONAL: ";

            if (CheckBox1.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Exercise intolerance | ";
            }
            if (CheckBox2.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Weight loss/gain | ";
            }
            if (CheckBox3.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Night sweats | ";
            }
            if (CheckBox4.Checked == true)
            {
                txtCons.Text = txtCons.Text + "Fever | ";
            }
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            string symp = "Constitutional";
            string conn = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);

            cmd1.Parameters.AddWithValue("@patient_id1", mrn);
            cmd1.Parameters.AddWithValue("@code1", apc);
            cmd1.Parameters.AddWithValue("@value1", "ROS");
            string des = txtCons.Text;
            cmd1.Parameters.AddWithValue("@note1", des);
            string d = DateTime.Now.ToString();
            cmd1.Parameters.AddWithValue("@datestamp1", d);
            cmd1.Parameters.AddWithValue("@review_type1", symp);
            cmd1.ExecuteNonQuery();
            con.Close();
            txtCons.Text = "";
        }

        protected void txtHOM_TextChanged(object sender, EventArgs e)
        {
           
            if (txtHOM.Text == "HOM" )
            {
                txtHOM.Text = "";
                Response.Redirect("ReviewofSystem.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
            }
            
        }
    }
}