using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crud
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
            Label3.Text = "Data has been Inserted successfully";
            GridView1.DataBind();
        }
        protected void GridView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
            Label3.Text = "Data has been Deleted successfully";
            GridView1.DataBind();
        }
    }
}