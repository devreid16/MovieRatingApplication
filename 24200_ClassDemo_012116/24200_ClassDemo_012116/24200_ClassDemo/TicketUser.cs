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
     /// <summary>
     ///  creates user account
     /// </summary>
     /// <returns>message to user</returns>
       
        public string CreateAccount()
        {
            //congratulations... set variables before you call 
            string message = "Congratuations " + FirstName + " " + LastName +" you created your User Name" + UserName;

            return message;
        }

    }
}