using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP229_Lesson1
{
    public partial class _Default : Page
    {
        /**
         * <summary>
         * This Method executes every time the page loads
         * </summary>
         */ 
        protected void Page_Load(object sender, EventArgs e)
        {
            HelloLabel.Text = "Hello And Good Bye !";
        }
    }
}