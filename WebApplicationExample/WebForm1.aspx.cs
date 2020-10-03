﻿using System;
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
            
        }
    }
}