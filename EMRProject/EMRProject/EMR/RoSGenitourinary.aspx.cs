﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMR
{
    public partial class RoSGenitourinary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtHOM.Focus();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            txtGeni.Text = "GENITOURINARY: ";
            if (CheckBox1.Checked == true)
            {
                txtGeni.Text = txtGeni.Text + " Urinary Loss Of Control | ";
            }
            if (CheckBox2.Checked == true)
            {
                txtGeni.Text = txtGeni.Text + " Difficulty Of Urinating | ";
            }
            if (CheckBox3.Checked == true)
            {
                txtGeni.Text = txtGeni.Text + " Increases Urinary Frequency | ";
            }
            if (CheckBox4.Checked == true)
            {
                txtGeni.Text = txtGeni.Text + " Hematuria(Blood In Urine) | ";
            }
            if (CheckBox5.Checked == true)
            {
                txtGeni.Text = txtGeni.Text + " Incomplete Emptying | ";
            }
            string mrn = Session["smrn"].ToString();
            string apc = Session["sapc"].ToString();
            string symp = "Genitourinary";
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D8FRGB1\SQLEXPRESS;Initial Catalog=EMRdb;Integrated Security=True");

            con.Open();
            SqlCommand cmd1 = new SqlCommand("Insert into Review_of_System " + "(patient_id,code,value,note,datestamp,review_type)values(@patient_id1,@code1,@value1,@note1,@datestamp1,@review_type1)", con);

            cmd1.Parameters.AddWithValue("@patient_id1", mrn);
            cmd1.Parameters.AddWithValue("@code1", apc);
            cmd1.Parameters.AddWithValue("@value1", "ROS");
            string des = txtGeni.Text;
            cmd1.Parameters.AddWithValue("@note1", des);
            string d = DateTime.Now.ToString();
            cmd1.Parameters.AddWithValue("@datestamp1", d);
            cmd1.Parameters.AddWithValue("@review_type1", symp);
            cmd1.ExecuteNonQuery();
            con.Close();
            txtGeni.Text = "";
        }

        protected void txtHOM_TextChanged(object sender, EventArgs e)
        {
            if (txtHOM.Text == "HOM")
            {
                txtHOM.Text = "";
                Response.Redirect("ReviewofSystem.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
            }
        }
    }
}