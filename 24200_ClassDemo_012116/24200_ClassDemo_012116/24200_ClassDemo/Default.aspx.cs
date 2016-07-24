﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _24200_ClassDemo
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            // if (!Page.IsPostBack)
            {
                Random RandomClass = new Random();

                for (int i = 0; i < 5; i++)
                {

                    int randomNumber = RandomClass.Next(1, 300);
                    sections.Items.Add(randomNumber.ToString());
                }

            }
        }
        
        protected void submit_Click(object sender, EventArgs e)
        {

            TicketOrder myOrder =
            new TicketOrder(Convert.ToInt32(sections.SelectedValue), Convert.ToInt32(qtyTickets.Text));
            lblOutput.Text = "your ticket order cost is " + myOrder.CalcTicketCost();

            //   int price = CalcTicketCost(Convert.ToInt32(sections.SelectedItem.Value), Convert.ToInt32(qtyTickets.Text));

            //     lblOutput.Text = "The ticket cost is: " + price;

        }
        protected void btnCreateUser_Click(object sender, EventArgs e)
        {
            TicketUser myUser = new TicketUser();
            myUser.FirstName = firstName.Text;
            myUser.LastName = lastName.Text;
            myUser.UserName = userName.Text;


            lblOutput.Text = myUser.CreateAccount();
        }
    }
}