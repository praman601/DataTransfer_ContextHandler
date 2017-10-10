using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataTransfer_ContextHandler
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnWebform2_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm2.aspx");

        }
    }
}