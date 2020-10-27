using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class datalistex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable Table = new DataTable();
            Table.Columns.Add("FirstName");
            Table.Columns.Add("LastName");
            Table.Columns.Add("Designation");
            Table.Columns.Add("Location");
            Table.Columns.Add("Country");


            Table.Rows.Add( "Haritha","Yelleti", "s/w Engineer","Vizag","India");
            Table.Rows.Add("Vamsi", "Yelleti", "Data baseEngineer", "Vizag", "India");
            Table.Rows.Add("Prithvi", "Yelleti", "Mechanical Engineer", "Banglore", "India");
            Table.Rows.Add("Tejaswi", "Yelleti", "botanist", "Hyderabad", "India");
            Table.Rows.Add("Sruthi", "Kupplili", "s/w Engineer", "Visakhapatnam", "India");
            Table.Rows.Add("Roopa", "Palisetti", "Testing Engineer", "Vizag", "India");
            Table.Rows.Add("Varun", "Palisetti", "Database Adminstrator", "Cape Town", "South Africa");
            Table.Rows.Add("Uday", "Gandepalli", ".Net DEveloper", "California", "U.S");
            Table.Rows.Add("Sekhar", "Gandepalli", "s/w Engineer", "Hyderabad", "India");
            Table.Rows.Add("Sai", "Gandepalli", "Engineer", "Cape Town", "South Africa");

            DataList1.DataSource = Table;
            DataList1.DataBind();
        }
    }
}