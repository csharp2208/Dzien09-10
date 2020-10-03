using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationExample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (String key in Request.Headers.AllKeys)
            {
                lblRequest.Text += $" {key} = {Request.Headers[key]} <br>";
            }
            lblRequest.Text += $"Metoda HTTP: {Request.HttpMethod} <br>";

            //IsPostBack == true, to znak ze strona ładuje się poprzez POST

            lblRequest.Text += "<br> Cookies: <br/>";
            foreach (String key in Request.Cookies.AllKeys)
            {
                lblRequest.Text += $" {key} = {Request.Cookies[key].Value} <br>";
            }
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            lblName.Text = tbName.Text;
            Response.SetCookie(new HttpCookie("name", lblName.Text));
        }
    }
}