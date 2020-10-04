using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
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

        public String GetDoctor(int doctorId)
        {
            switch (doctorId)
            {
                case 1:
                    return "Jan Kowalski";
                case 2:
                    return "Janina Ziętek";
                case 3:
                    return "Mirosław Nowak";
                default:
                    return "---";
            }
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

        String cs = ConfigurationManager.
           ConnectionStrings["edoctorConnectionString"].ConnectionString;


        protected void gridView_RowCommand(object sender, 
            GridViewCommandEventArgs e)
        {
            if (e.CommandName=="DeleteRow")
            {
                int rowId = Convert.ToInt32(e.CommandArgument);
                using (MySqlConnection conn = new MySqlConnection(cs))
                {
                    conn.Open();
                    String sql = $"DELETE FROM visits WHERE id={rowId}";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    gridView.DataBind(); //odswieża dane w grid

                }
            }
        }
    }
}