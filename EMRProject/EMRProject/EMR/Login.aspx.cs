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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-AHH45AF\SQLEXPRESS;Initial Catalog=EMRdb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Users where usename='" + txtUser.Text + "' and pw='" + txtPass.Text + "' ", con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                   
                    if (dr.GetValue(2).ToString() == "Doctor")
                    {
                        Session["category"] = "Doctor";
                        Response.Redirect("DoctorDashboard.aspx");
                    }
                    else if(dr.GetValue(2).ToString() == "MA")
                    {
                        Session["category"] = "MA";
                        Response.Redirect("MADashboard.aspx");
                    }
                    else if(dr.GetValue(2).ToString() == "Clerk")
                    {
                        Session["category"] = "Clerk";
                        Response.Redirect("PatientRegistration.aspx");
                    }
                }
            }
    }

    

        protected void Button2_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
            txtUser.Text = "";
            
        }
    }
}