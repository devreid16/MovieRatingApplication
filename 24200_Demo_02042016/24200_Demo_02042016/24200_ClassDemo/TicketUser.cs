using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _24200_ClassDemo
{
    public class TicketUser
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        public TicketUser()
        {
            
        }
        ///// <summary>
        ///// This method creates the account for a ticket user.
        ///// </summary>
        ///// <returns>A string message.</returns>
        ///// <param name="Name">a string that represents a name.</param>
        //public string CreateAccount()
        //{
        //    //Congratulations John Doe.  Your account has been created.  Your username is XXXXXXX.

        //    string message = "Congrats " + FirstName + " " + LastName +
        //                     " Your account has been created.  Your username is " + UserName + ".";
        //    return message;
        //}


        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            //return base.ToString();
            string message = "Congrats " + FirstName + " " + LastName +
                            " Your account has been created.  Your username is " + UserName + ".";
            return message;

        }
    }
}