using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EDoctor
{
    public partial class VisitList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.Cells[8].Text=="0")
                {
                    e.Row.Cells[8].Text = "NOWA";
                }
                
                if (e.Row.Cells[8].Text == "1")
                {
                    e.Row.Cells[8].Text = "AKCEPTACJA";
                }

                if (e.Row.Cells[8].Text == "-1")
                {
                    e.Row.Cells[8].Text = "ANULOWANO";
                }
            }
        }
    }
}