using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication4
{
    public partial class Datagrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable Table = new DataTable();
            Table.Columns.Add("ID");
            Table.Columns.Add("Name");
            Table.Columns.Add("Email");
            Table.Columns.Add("Phoneno");
            Table.Columns.Add("Location");
            Table.Columns.Add("Pin code");

            Table.Rows.Add(101,"sachin","Sachinpratik@gmail.com",99898900,"Vizag",54890);
            Table.Rows.Add(102, "Haritha", "haritha51298@gmail.com",87908098098,"hyderabad",67890);
            Table.Rows.Add(103, "vamsi", "vamsi@gmail.com",8909909099,"s.a",789980);
            Table.Rows.Add(104, "roopa", "roopapallisetty@gmail.com",8900909090,"vizag",789890);
            Table.Rows.Add(104, "vamsisairam", "vamsi8909@gmail.com", 8956798099, "pune", 70998);
            Table.Rows.Add(105, "varun", "varunpallisetty@gmail.com", 67878978908, "vizag", 7897908);


            DataGrid1.DataSource = Table;
            DataGrid1.DataBind();

        }
    }
}