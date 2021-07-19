using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Script.Serialization;
using System.Configuration;

namespace EMR
{
    /// <summary>
    /// Summary description for Handler1
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string term = context.Request["term"] ?? "";
            List<string> listDrugNames = new List<string>();
            string cs = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            using(SqlConnection con1=new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spDrugNames", con1);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter()
                {
                      ParameterName="@term",
                      Value=term
                });
                con1.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    listDrugNames.Add(rdr["Generic_Name"].ToString());
                }
            }
            JavaScriptSerializer js = new JavaScriptSerializer();
            context.Response.Write(js.Serialize(listDrugNames));

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}