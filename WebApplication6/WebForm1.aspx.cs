﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{

    
    public partial class WebForm1 : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int parsedValue;
            if (!int.TryParse(TextBox1.Text, out parsedValue))
            {
                Label1.Text = "This is a number only field";
                return;
            }
            else
            {
                parsedValue = Convert.ToInt32(TextBox1.Text);
                
            }
        }
        
        

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}