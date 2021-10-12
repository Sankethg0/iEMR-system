using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMR
{
    public partial class ReviewofSystem : System.Web.UI.Page
    {
        public object Repeater1 { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            txtHOM.Focus();
            if (!IsPostBack == true)
            {
                GridView1.DataSource = SqlDataSource1;
                GridView1.DataBind();

            }

        }
        
        protected void txtHOM_TextChanged(object sender, EventArgs e)
        {
            if (txtHOM.Text == "HOM")
            {
                txtHOM.Text = "";
                Response.Redirect("DoctorDashboard.aspx?apc=" + Session["sapc"].ToString() + "&mrn=" + Session["smrn"].ToString());
            }
            else if (txtHOM.Text == "General")
            {
                Response.Redirect("../Medical Assistant/ROSAll.aspx");
            }
            else if (txtHOM.Text == "Constitutional")
            {
                Response.Redirect("../Medical Assistant/RoSConstitutional.aspx");
            }
            else if(txtHOM.Text == "Eyes")
            {
                Response.Redirect("../Medical Assistant/RoSEyes.aspx");
            }
            else if (txtHOM.Text == "ENMT")
            {
                Response.Redirect("../Medical Assistant/RoSENMT.aspx");
            }
            else if (txtHOM.Text == "Cardiovascular")
            {
                Response.Redirect("../Medical Assistant/RoSCardiovascular.aspx");
            }
            else if (txtHOM.Text == "Respiratory")
            {
                Response.Redirect("../Medical Assistant/RoSRespiratory.aspx");
            }
            else if (txtHOM.Text == "Gastrointestinal")
            {
                Response.Redirect("../Medical Assistant/RoSGastrointestinal.aspx");
            }
            else if (txtHOM.Text == "Genitourinary")
            {
                Response.Redirect("../Medical Assistant/RoSGenitourinary.aspx");
            }
            else if (txtHOM.Text == "Musculoskeletal")
            {
                Response.Redirect("../Medical Assistant/RoSMusculoskeletal.aspx");
            }
            else if (txtHOM.Text == "Neurologic")
            {
                Response.Redirect("../Medical Assistant/RoSNeurologic.aspx");
            }
            else if (txtHOM.Text == "Psychiatric")
            {
                Response.Redirect("../Medical Assistant/RoSPsychiatric.aspx");
            }
            else if (txtHOM.Text == "Endocrine")
            {
                Response.Redirect("../Medical Assistant/RoSEndocrine.aspx");
            }
            else if (txtHOM.Text == "Hematologic" || txtHOM.Text== "Lymphatic")
            {
                Response.Redirect("../Medical Assistant/RoSHematologic.aspx");
            }
            else if(txtHOM.Text== "Allergic" || txtHOM.Text== "Immunologic")
            {
                Response.Redirect("../Medical Assistant/RoSAllergic.aspx");
            }
            
        }
    }
}