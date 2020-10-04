using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EDoctor
{

    public partial class EditVisit : System.Web.UI.Page
    {

        String cs = ConfigurationManager.
                    ConnectionStrings["edoctorConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // GET
                int rowId;
                if (!Int32.TryParse(Request.Params["id"], out rowId))
                {
                    Response.Redirect("~/VisitList");
                } else
                {
                    using (MySqlConnection conn = new MySqlConnection(cs))
                    {
                        conn.Open();
                        String sql = $"select * from visits where id={rowId}";
                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        adapter.SelectCommand = new MySqlCommand(sql, conn);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        if (dt.Rows.Count==0)
                        {
                            Response.Redirect("~/VisitList");
                        }
                        tbHiddenId.Value = rowId.ToString();
                    }
                }
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            int status = Convert.ToInt32(ddStatus.SelectedValue);
            int rowId = Convert.ToInt32(tbHiddenId.Value);

            String sql = $"UPDATE visits set STATUS={status} WHERE id={rowId}";
            using (MySqlConnection conn = new MySqlConnection(cs))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                Response.Redirect("~/VisitList");
            }
        }
    }
}