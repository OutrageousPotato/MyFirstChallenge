﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string userAge = age.Text;
            string userMoney = money.Text;

            string result = "At " + userAge + ", I would have expected you to have more than " + userMoney + " in your pocket.";

            Label1.Text = result;
        }
    }
}