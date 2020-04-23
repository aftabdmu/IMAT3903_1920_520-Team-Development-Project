using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonbtnRegister_Click(object sender, EventArgs e)
    {   // this piece of code will redirect to the register page
        Response.Redirect("CustomerRegister.aspx");
    }

    protected void ButtonbtnLogin_Click(object sender, EventArgs e)
    {
        // this piece of code will redirect to Myacount page
        Response.Redirect("CustomerAcount.aspx");
    }
}