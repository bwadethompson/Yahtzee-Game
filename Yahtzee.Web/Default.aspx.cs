using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yahtzee.Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
        }

        protected void NewGameButton_Click(object sender, ImageClickEventArgs e)
        {
            if (Page.IsValid)
            { Response.Redirect("GameBoard.aspx"); }
        }
    }
}