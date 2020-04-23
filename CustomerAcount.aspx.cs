using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MyAcount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonGoBack_Click(object sender, EventArgs e)
    {  // this piece of code will redirect you to the login page
        Response.Redirect("StaffCustomerDefault.aspx");
    }


}