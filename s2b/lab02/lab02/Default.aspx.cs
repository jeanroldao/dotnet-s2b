using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab02
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime[] dt = new DateTime[2];
            int iDate;
            dt[0] = new DateTime(2002, 5, 1);
            dt[1] = new DateTime(2002, 6, 1);
            for (iDate = 0; iDate < 2; iDate++)
            {
                Response.Write("Indice = " + iDate + " & Data = " + dt[iDate].ToShortDateString() + "<br>");
            }


        }
    }
}