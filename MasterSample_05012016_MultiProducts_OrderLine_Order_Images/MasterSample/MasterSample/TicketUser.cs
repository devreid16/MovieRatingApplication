using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MasterSample
{
    public class TicketUser
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Password { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
         
        public string Email { get; set; }
        public Int32 UserID { get; set; }

        public TicketUser()
        {

        }
        /// <summary>
        /// This method creates the account for a ticket user.
        /// </summary>
        /// <returns>A string message.</returns>
        /// <param name="Name">a string that represents a name.</param>
        public string CreateAccount()
        {
            DataAccess da = new DataAccess();

            ArrayList parms = new ArrayList();

            SqlParameter firstNameParameter = new SqlParameter();
            firstNameParameter.Value = FirstName;
            firstNameParameter.ParameterName = "FirstName";
            parms.Add(firstNameParameter);

            SqlParameter lastNameParameter = new SqlParameter();
            lastNameParameter.Value = LastName;
            lastNameParameter.ParameterName = "LastName";
            parms.Add(lastNameParameter);

            SqlParameter userNameParameter = new SqlParameter();
            userNameParameter.Value = UserName;
            userNameParameter.ParameterName = "UserName";
            parms.Add(userNameParameter);

            SqlParameter addressParameter = new SqlParameter();
            addressParameter.Value = Address;
            addressParameter.ParameterName = "Address";
            parms.Add(addressParameter);

            SqlParameter cityParameter = new SqlParameter();
            cityParameter.Value = City;
            cityParameter.ParameterName = "City";
            parms.Add(cityParameter);

            SqlParameter stateParameter = new SqlParameter();
            stateParameter.Value = State;
            stateParameter.ParameterName = "State";
            parms.Add(stateParameter);

            SqlParameter zipParameter = new SqlParameter();
            zipParameter.Value = Zip;
            zipParameter.ParameterName = "Zip";
            parms.Add(zipParameter);

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

            da.InsertUpdateData("InsertNewUser",parms);

            //Congratulations John Doe.  Your account has been created.  Your username is XXXXXXX.

            string message = "Congrats " + FirstName + " " + LastName +
                             " Your account has been created.  Your username is " + UserName + ".";
            return message;
        }






        public string UpdateAccount()
        {
            DataAccess da = new DataAccess();

            ArrayList parms = new ArrayList();

            SqlParameter firstNameParameter = new SqlParameter();
            firstNameParameter.Value = FirstName;
            firstNameParameter.ParameterName = "FirstName";
            parms.Add(firstNameParameter);

            SqlParameter lastNameParameter = new SqlParameter();
            lastNameParameter.Value = LastName;
            lastNameParameter.ParameterName = "LastName";
            parms.Add(lastNameParameter);

            SqlParameter userNameParameter = new SqlParameter();
            userNameParameter.Value = UserName;
            userNameParameter.ParameterName = "username";
            parms.Add(userNameParameter);
            

            SqlParameter addressParameter = new SqlParameter();
            addressParameter.Value = Address;
            addressParameter.ParameterName = "Address";
            parms.Add(addressParameter);

            SqlParameter cityParameter = new SqlParameter();
            cityParameter.Value = City;
            cityParameter.ParameterName = "City";
            parms.Add(cityParameter);

            SqlParameter stateParameter = new SqlParameter();
            stateParameter.Value = State;
            stateParameter.ParameterName = "State";
            parms.Add(stateParameter);

            SqlParameter zipParameter = new SqlParameter();
            zipParameter.Value = Zip;
            zipParameter.ParameterName = "Zip";
            parms.Add(zipParameter);

            SqlParameter phoneParameter = new SqlParameter();
            phoneParameter.Value = Phone;
            phoneParameter.ParameterName = "Phone";
            parms.Add(phoneParameter);

            SqlParameter emailParameter = new SqlParameter();
            emailParameter.Value = Email;
            emailParameter.ParameterName = "Email";
            parms.Add(emailParameter);

             

            da.InsertUpdateData("UpdateUser", parms);

            //Congratulations John Doe.  Your account has been created.  Your username is XXXXXXX.

            string message = "Congrats " + FirstName + " " + LastName +
                             " Your account has been updated.";
            return message;
        }






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

        public static TicketUser LoginUser(string username, string password)
        {
            DataAccess da = new DataAccess();
            ArrayList parms = new ArrayList();

            SqlParameter passwordParameter = new SqlParameter();
            passwordParameter.Value = password;
            passwordParameter.ParameterName = "password";
            parms.Add(passwordParameter);

            SqlParameter usernameParameter = new SqlParameter();
            usernameParameter.Value = username;
            usernameParameter.ParameterName = "username";
            parms.Add(usernameParameter);


            SqlDataReader dr = da.GetDataReader("LoginUser", parms);

            if (dr != null)
            {
                while (dr.Read())
                {
                    ////if user is not in database, return null 
                    //if (dr["username"] == DBNull.Value || username != dr["@username"].ToString())
                    //{
                    //    return null;
                    //}
                    //else  //they are in the db, we need to create a user object and use it 
                    {
                        TicketUser foundUser = new TicketUser();

                        foundUser.FirstName = dr["FirstName"].ToString();
                        foundUser.LastName = dr["LastName"].ToString();
                        foundUser.Address = dr["Address"].ToString();
                        foundUser.City = dr["City"].ToString();
                        foundUser.State = dr["State"].ToString();
                        foundUser.Zip = dr["Zip"].ToString();
                        foundUser.Phone = dr["Phone"].ToString();
                        foundUser.Password = dr["Password"].ToString();
                         
                        foundUser.UserName = dr["UserName"].ToString();
                        foundUser.UserID = Convert.ToInt32(dr["Id"].ToString());
                        return foundUser;
                    } 
                }
                
            }

            return null;
        }
    }
}