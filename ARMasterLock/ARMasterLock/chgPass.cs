using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ARMasterLock
{
    public class chgPass
    {       
            public string UserName { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Password { get; set; }
            public string ConfPassword { get; set; }
            public string NewPassword { get; set; }

            public chgPass()
            {

            }

            /// <summary>
            ///  Update User Profile and generate message
            /// </summary>
            /// <returns>message to user</returns>
            /// 
            public string UpdatePassword()
            {
                DataAccess da = new DataAccess();

                ArrayList parms = new ArrayList();

                SqlParameter userNameParameter = new SqlParameter();
                userNameParameter.Value = UserName;
                userNameParameter.ParameterName = "UserName";
                parms.Add(userNameParameter);

                SqlParameter passwordParameter = new SqlParameter();
                passwordParameter.Value = Password;
                passwordParameter.ParameterName = "Password";
                parms.Add(passwordParameter);

                SqlParameter newPasswordParameter = new SqlParameter();
                newPasswordParameter.Value = NewPassword;
                newPasswordParameter.ParameterName = "NewPassword";
                parms.Add(newPasswordParameter);

                SqlParameter ConfPasswordParameter = new SqlParameter();
                ConfPasswordParameter.Value = ConfPassword;
                ConfPasswordParameter.ParameterName = "ConfPassword";
                parms.Add(ConfPasswordParameter);

                da.InsertUpdateData("changePassword", parms);

                string message = "Congratuations " + FirstName + " " + LastName +
                          " you sucessfully changed your Password";
                return message;
            }
       }
}