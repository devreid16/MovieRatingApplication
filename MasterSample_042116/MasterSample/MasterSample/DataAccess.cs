using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace MasterSample
{
    public class DataAccess
    {
        public SqlDataReader GetDataReader(string procName, ArrayList parms)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand(procName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            if (parms != null)
            {
                foreach (SqlParameter sqlParm in parms)
                {
                    SqlParameter tempParameter = new SqlParameter(sqlParm.ParameterName, sqlParm.Value);
                    cmd.Parameters.Add(tempParameter);
                }
            }



            conn.Open();

            SqlDataReader dataReader = cmd.ExecuteReader();



            return dataReader;
        }

        public void InsertUpdateData(string procName, ArrayList parms)
        {


            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand(procName, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            foreach (SqlParameter sqlParm in parms)
            {
                SqlParameter tempParameter = new SqlParameter(sqlParm.ParameterName, sqlParm.Value);
                cmd.Parameters.Add(tempParameter);
            }


            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}