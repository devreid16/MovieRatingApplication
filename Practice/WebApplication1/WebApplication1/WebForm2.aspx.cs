using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();

            int[] lock_Numbers;
            lock_Numbers = new int[3];

            lock_Numbers[0] = 3;
            lock_Numbers[1] = 5;
            lock_Numbers[2] = 7;
                
            for (int i = 0; i != lock_Numbers.Length; i++)
            {
                lock_Numbers[i] = i + 3;
                ListBox1.Items.Add(lock_Numbers[i].ToString());
            }      
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}