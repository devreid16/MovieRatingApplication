using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
          //  Label1.Text = "In the Drop Down Your selection " +
           //     DropDownList1.SelectedValue + "<br/>";

        //    foreach (ListItem item in CheckBoxList1.Items)
         //   {
         //       if (item.Selected == true)
           //     {
            //        Label1.Text += "In the CheckBox Your selection " + Items.Values + "<br/>";
            //    }
           // }
       // }

    //    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
      //   {
            foreach (ListItem item in CheckBoxList1.Items)
            {
                if (item.Selected == true)
                {
                    Label1.Text += "In the CheckBox Your selection " + Items.Values + "<br/>";
                }
            }
        }
    }
}     
    