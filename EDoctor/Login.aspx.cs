using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EDoctor
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private String HashPass(string pass)
        {
            using (SHA1Managed sha1 = new SHA1Managed()) {
                byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(pass));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        String cs = ConfigurationManager.
            ConnectionStrings["edoctorConnectionString"].ConnectionString;

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String user = tbLogin.Text.Trim();
            String pass = tbPassword.Text.Trim();
            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(pass) )
            {
                lblResult.Text = "Podaj login i hasło";
                return;
            }
            String hashPass = HashPass(pass);
            String sql = "SELECT * FROM users WHERE " +
                "login=@login AND password=@pass AND active=1";
            using (MySqlConnection conn = new MySqlConnection(cs))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@login", MySqlDbType.VarChar, 50).Value = user;
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar, 200).Value = hashPass;
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count==0)
                {
                    lblResult.Text = "Zły login, hasło albo user nieaktywny";
                } else
                {
                    // ustanowienie sesji użytkownika
                    Session["auth_user"] = dt.Rows[0]["login"].ToString();
                    Response.Redirect("~/RegisterVisit");
                }
            }

        }
    }
}