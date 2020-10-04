using EDoctor.App_Code;
using System;
using System.Collections.Generic;
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
            // obsluga zapisu do bazy
            if (fuImage.HasFile)
            {
                if (fuImage.PostedFile.ContentType=="image/png")
                {
                    if (fuImage.PostedFile.ContentLength<500000)
                    {
                        //upload
                        String filename = Guid.NewGuid().ToString("N") +
                            "-" + Path.GetFileName(fuImage.FileName);
                        String fn = Server.MapPath("~/uploads/") + filename;
                        fuImage.SaveAs(fn);
                    } else
                    {
                        lblResult.Text = "Plik za duży";
                        lblResult.ForeColor = Color.Red;
                    }
                } else
                {
                    lblResult.Text = "Podany plik nie jest PNG";
                    lblResult.ForeColor = Color.Red;
                }
            }
        }
    }
}