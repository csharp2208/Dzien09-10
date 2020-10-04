using EDoctor.App_Code;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EDoctor
{
    public partial class RegisterVisit2 : System.Web.UI.Page
    {
        VisitData data = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["auth_user"] == null)
            {
                Response.Redirect("~/Login");
            }

            try
            {
                data = (VisitData)Session["RegForm"];
                if (data == null) 
                    throw new Exception();
            } catch (Exception exc)
            {
                Response.Redirect("~/RegisterVisit");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String filename = "";
            // obsluga zapisu do bazy
            if (fuImage.HasFile)
            {
                if (fuImage.PostedFile.ContentType == "image/png")
                {
                    if (fuImage.PostedFile.ContentLength < 500000)
                    {
                        //upload
                        filename = Guid.NewGuid().ToString("N") +
                            "-" + Path.GetFileName(fuImage.FileName);
                        String fn = Server.MapPath("~/uploads/") + filename;
                        fuImage.SaveAs(fn);
                    }
                    else
                    {
                        lblResult.Text = "Plik za duży";
                        lblResult.ForeColor = Color.Red;
                        return;
                    }
                }
                else
                {
                    lblResult.Text = "Podany plik nie jest PNG";
                    lblResult.ForeColor = Color.Red;
                    return;
                }
            }

            // zapis wartosci z formularza do bazy
            String sql = @"
                INSERT INTO visits
                (fname, lname, pesel, email, doctor, card, visit_date, descr, image)
                VALUES  
                (@fname, @lname, @pesel, @email, @doctor, @card, @visit_date, @descr, @image)
            ";
            String cs = ConfigurationManager.
                       ConnectionStrings["edoctorConnectionString"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(cs))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@fname", MySqlDbType.VarChar, 50).Value = data.FirstName;
                cmd.Parameters.Add("@lname", MySqlDbType.VarChar, 50).Value = data.LastName;
                cmd.Parameters.Add("@pesel", MySqlDbType.VarChar, 20).Value = data.PESEL;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar, 250).Value = data.Email;
                cmd.Parameters.Add("@doctor", MySqlDbType.Int32).Value = data.DoctorId;
                cmd.Parameters.Add("@card", MySqlDbType.VarChar, 50).Value = data.CardNumber;
                cmd.Parameters.Add("@visit_date", MySqlDbType.Date).Value = data.DateVisit;
                cmd.Parameters.Add("@descr", MySqlDbType.Text).Value = tbDescr.Text;
                cmd.Parameters.Add("@image", MySqlDbType.VarChar, 250).Value = filename;

                cmd.ExecuteNonQuery();
                lblResult.Text = "Wszystko OK";
                lblResult.ForeColor = Color.Black;

                Button1.Enabled = false;
                Session.Remove("RegForm");

            }
        }
    }
}