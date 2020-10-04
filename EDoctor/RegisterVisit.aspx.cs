using EDoctor.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EDoctor
{
    public partial class RegisterVisit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["auth_user"]==null)
            {
                Response.Redirect("~/Login");
            }
        }

        protected void cbVIP_CheckedChanged(object sender, EventArgs e)
        {
            tbVIPNumber.Visible = cbVIP.Checked;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                VisitData data = new VisitData();
                data.FirstName = tbFName.Text;
                data.LastName = tbLName.Text;
                data.Email = tbEmail.Text;
                data.PESEL = tbPESEL.Text;
                data.CardNumber = tbVIPNumber.Text;
                data.DoctorId = Convert.ToInt32( ddDoctor.SelectedValue );
                data.DateVisit = calVisitDate.SelectedDate;
                Session["RegForm"] = data;
                Response.Redirect("~/RegisterVisit2");
            }
        }
    }
}