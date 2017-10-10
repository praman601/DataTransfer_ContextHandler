using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataTransfer_ContextHandler
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Page lastPage = (Page)Context.Handler;
                lblName.Text = ((TextBox)lastPage.FindControl("txtName")).Text;

                lblEmail.Text = ((TextBox)lastPage.FindControl("txtEmail")).Text;
            }
            }
    }
}