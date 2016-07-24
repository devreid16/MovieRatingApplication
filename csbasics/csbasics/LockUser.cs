using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace csbasics
{
    public class LockUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        public LockUser()
        {

        }

        /// <summary>
        ///  creates user account and generate message
        /// </summary>
        /// <returns>message to user</returns>


        public override string ToString()
        {
            //   return base.ToString();
           

            //congratulations... set variables before you call 
            string message = "Congratuations " + FirstName + " " + LastName + 
                    " you created your Username: " + UserName;

            return message;
        }
    }
}