using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SamplePorj1.Models
{
    public class Context
    {
        private SqlConnection con;
        private void connection()
        {
            string conn = System.Configuration.ConfigurationManager.ConnectionStrings["Jobportal"].ToString();
            con = new SqlConnection(conn);
        }
    }
}