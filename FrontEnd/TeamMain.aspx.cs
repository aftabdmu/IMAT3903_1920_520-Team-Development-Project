using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSAOptician_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("SAMain.aspx");
    }
}