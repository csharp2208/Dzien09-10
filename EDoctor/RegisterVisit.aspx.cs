﻿using System;
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

        }

        protected void cbVIP_CheckedChanged(object sender, EventArgs e)
        {
            tbVIPNumber.Visible = cbVIP.Checked;
        }
    }
}