using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Web;

namespace ARMasterLock
{
        public class UserUpdate
    {
        public string UserName { get; set; }
        public int customerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public UserUpdate()
        {

        }
        
        /// <summary>
        ///  Update User Profile and generate message
        /// </summary>
        /// <returns>message to user</returns>
        /// 
        public string UpdateProfile()
        {
            DataAccess da = new DataAccess();

            ArrayList parms = new ArrayList();

            SqlParameter userNameParameter = new SqlParameter();
            userNameParameter.Value = UserName;
            userNameParameter.ParameterName = "UserName";
            parms.Add(userNameParameter);

            SqlParameter fNameParameter = new SqlParameter();
            fNameParameter.Value = FirstName;
            fNameParameter.ParameterName = "FirstName";
            parms.Add(fNameParameter);

            SqlParameter lNameParameter = new SqlParameter();
            lNameParameter.Value = LastName;
            lNameParameter.ParameterName = "LastName";
            parms.Add(lNameParameter);

            SqlParameter addressParameter = new SqlParameter();
            addressParameter.Value = Address;
            addressParameter.ParameterName = "Address";
            parms.Add(addressParameter);

            SqlParameter cityParameter = new SqlParameter();
            cityParameter.Value = City;
            cityParameter.ParameterName = "City";
            parms.Add(cityParameter);

            SqlParameter ddlStateListParameter = new SqlParameter("@State", State);
            ddlStateListParameter.Value = State;
            ddlStateListParameter.ParameterName = "State";
            parms.Add(ddlStateListParameter);

            SqlParameter zipCodeParameter = new SqlParameter();
            zipCodeParameter.Value = ZipCode;
            zipCodeParameter.ParameterName = "ZipCode";
            parms.Add(zipCodeParameter);

            SqlParameter phoneParameter = new SqlParameter();
            phoneParameter.Value = Phone;
            phoneParameter.ParameterName = "Phone";
            parms.Add(phoneParameter);

            SqlParameter emailParameter = new SqlParameter();
            emailParameter.Value = Email;
            emailParameter.ParameterName = "Email";
            parms.Add(emailParameter);

            da.InsertUpdateData("updateProfile", parms);

            string message = "Congratuations " + FirstName + " " + LastName +
                      " you sucessfully updated your Profile";
            return message;
        }
    }
    /// <summary>
    /// Lock User Create Account and display message
    /// </summary>
    /// <returns></returns>
    /// 
    public class LockUser
    {
        public int customerId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public LockUser()
        {

        }

        public string CreateAccount()
        {
            DataAccess da = new DataAccess();

            ArrayList parms = new ArrayList();

            SqlParameter userNameParameter = new SqlParameter();
            userNameParameter.Value = UserName;
            userNameParameter.ParameterName = "UserName";
            parms.Add(userNameParameter);

            SqlParameter fNameParameter = new SqlParameter();
            fNameParameter.Value = FirstName;
            fNameParameter.ParameterName = "FirstName";
            parms.Add(fNameParameter);

            SqlParameter lNameParameter = new SqlParameter();
            lNameParameter.Value = LastName;
            lNameParameter.ParameterName = "LastName";
            parms.Add(lNameParameter);

            SqlParameter addressParameter = new SqlParameter();
            addressParameter.Value = Address;
            addressParameter.ParameterName = "Address";
            parms.Add(addressParameter);

            SqlParameter cityParameter = new SqlParameter();
            cityParameter.Value = City;
            cityParameter.ParameterName = "City";
            parms.Add(cityParameter);

            SqlParameter ddlStateListParameter = new SqlParameter("@State", State);
            ddlStateListParameter.Value = State;
            ddlStateListParameter.ParameterName = "State";
            parms.Add(ddlStateListParameter);

            SqlParameter zipCodeParameter = new SqlParameter();
            zipCodeParameter.Value = ZipCode;
            zipCodeParameter.ParameterName = "ZipCode";
            parms.Add(zipCodeParameter);

            SqlParameter phoneParameter = new SqlParameter();
            phoneParameter.Value = Phone;
            phoneParameter.ParameterName = "Phone";
            parms.Add(phoneParameter);

            SqlParameter emailParameter = new SqlParameter();
            emailParameter.Value = Email;
            emailParameter.ParameterName = "Email";
            parms.Add(emailParameter);

            SqlParameter passwordParameter = new SqlParameter();
            passwordParameter.Value = Password;
            passwordParameter.ParameterName = "Password";
            parms.Add(passwordParameter);

            da.InsertUpdateData("InsertNewUser", parms);

            string message = "Congratuations " + FirstName + " " + LastName +
                      " you created your Username:" + UserName;

            return message;
        }

        /// <summary>
        /// Method to find current users in database; set params for DataReader
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static LockUser LoginUser(string username, string password)
        {
            DataAccess da = new DataAccess();
            ArrayList parms = new ArrayList();

            SqlParameter userNameParameter = new SqlParameter();
            userNameParameter.Value = username;
            userNameParameter.ParameterName = "UserName";
            parms.Add(userNameParameter);

            SqlParameter passwordParameter = new SqlParameter();
            passwordParameter.Value = password;
            passwordParameter.ParameterName = "Password";
            parms.Add(passwordParameter);

            SqlDataReader dr = da.GetDataReader("LoginUser", parms);
            if (dr == null)
            {
                return null;
            }
            else if (dr.HasRows) while (dr.Read())

                {

                    LockUser UserFound = new LockUser();
                    UserFound.customerId = Convert.ToInt32(dr[0]);
                    UserFound.UserName = dr[1].ToString();
                    UserFound.FirstName = dr[2].ToString();
                    UserFound.LastName = dr[3].ToString();
                    UserFound.Address = dr[4].ToString();
                    UserFound.City = dr[5].ToString();
                    UserFound.State = dr[6].ToString();
                    UserFound.ZipCode = dr[7].ToString();
                    UserFound.Phone = dr[8].ToString();
                    UserFound.Email = dr[9].ToString();
                    UserFound.Password = dr[10].ToString();

                    return UserFound;
                }

            return null;
        }
        
    }
}
    