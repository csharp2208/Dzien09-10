using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationExample
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                //odczytujemy parametry z kontrolek
                StringBuilder sb = new StringBuilder();
                sb.Append("Checbox =" + CheckBox1.Checked + "<br/>");

                foreach(ListItem item in CheckBoxList1.Items)
                {
                    if (item.Selected)
                    {
                        sb.Append("check box list = " + item.Value + "<br/>");
                    }
                }

                sb.Append("textbox=" + TextBox1.Text + "<br/>");
                sb.Append("dropdownlist =" + DropDownList1.SelectedValue + "<br/>");
                sb.Append("listbox =" + ListBox1.SelectedValue + "<br/>");
                sb.Append("radio button list =" + RadioButtonList1.SelectedValue + "<br/>");

                lblResult.Text = sb.ToString();
            }
        }
    }
}