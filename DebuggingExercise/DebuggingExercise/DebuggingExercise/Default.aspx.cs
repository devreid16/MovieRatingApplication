using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DebuggingExercise
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {        
               
        }

        private int Factorial(int intNumber)
        {
            int intFac = 1;
            for (int i = intNumber; i > 1; i--)               
            {
                intFac = intFac * i;                
            }
            return intFac;
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt16(txtInputValue.Text) > -1)
                    lblDisplay.Text = Convert.ToString(Factorial(Convert.ToInt16(txtInputValue.Text)));
            }
            catch (FormatException)
            {
                lblDisplay.Text = "Please enter a number: ex:1, 2, 3...";
            }
            
        }
    }
}
