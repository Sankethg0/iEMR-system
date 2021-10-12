using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace EMR
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string conn = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection con = new SqlConnection(conn);
            txtHOM.Focus();
          
            if (!IsPostBack == true)
            {
                Calendar1.SelectedDate = DateTime.Now;
                txtDate.Text = Calendar1.SelectedDate.ToString("MM/dd/yyyy");
                GridView1.DataSource = SqlDataSource1;
                GridView1.DataBind();
               
            }
        }

       
    
        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            string val = Session["smrn"].ToString();
            string conn = System.Configuration.ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd1 = new SqlCommand("Insert into Orders" + "(patient_id,type,description,dosage,datestamp)values(@patient_id1,@type1,@description1,@dosage1,@datestamp1)", con);

            cmd1.Parameters.AddWithValue("@patient_id1", val);         
            cmd1.Parameters.AddWithValue("@type1","Med");
            cmd1.Parameters.AddWithValue("@description1",txtHOM.Text);
            cmd1.Parameters.AddWithValue("@dosage1",txtDosage.Text);
            cmd1.Parameters.AddWithValue("@datestamp1", txtDate.Text);
            cmd1.ExecuteNonQuery();
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
            txtHOM.Text = "";


        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
           txtDate.Text = Calendar1.SelectedDate.ToShortDateString();
           Calendar1.Visible = false;
        }
       
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)

        {
            string val = Session["smrn"].ToString();
            Label des = GridView1.Rows[e.RowIndex].FindControl("Label1") as Label;
            String mycon = @"Data Source=DESKTOP-D8FRGB1\SQLEXPRESS;Initial Catalog=EMRdb;Integrated Security=True";
            String updatedata = "delete from Orders where patient_id="+val+" AND description='" + des.Text + "'";
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = updatedata;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
        }

        protected void txtName_TextChanged(object sender, EventArgs e)
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