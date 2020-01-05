using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.Example
{
    class UserRepository
    {
        string connectionString = "Server=DESKTOP-SCH63NU\\SQLEXPRESS;Database=Task2;Integrated Security=True";

        public User GetUser(int id)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("usp_GetUser", sqlConnection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@UserId", SqlDbType.Int);
            command.Parameters[0].Value = id;
            sqlConnection.Open();
            SqlDataReader myReader = command.ExecuteReader();
            myReader.Read();
            var user = new User();
            user.FirstName = myReader["firstName"].ToString();
            user.Surname = myReader["surName"].ToString();
            user.LastName = myReader["lastName"].ToString();
            user.YearOfBirth = int.Parse(myReader["yearOfBirth"].ToString());


            myReader.Close();
            return user;

        }
        public void InsertUser(User u)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            SqlCommand command = new SqlCommand("usp_InsertUser", sqlConnection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@First_Name", SqlDbType.NVarChar, 500);
            command.Parameters[0].Value = u.FirstName;

            command.Parameters.Add("@Sur_Name", SqlDbType.NVarChar, 500);
            command.Parameters[1].Value = u.Surname;

            command.Parameters.Add("@Last_Name", SqlDbType.NVarChar, 500);
            command.Parameters[2].Value = u.LastName;

            command.Parameters.Add("@Birth_Year", SqlDbType.Int);
            command.Parameters[3].Value = u.YearOfBirth;

            command.ExecuteScalar();

        }

        public void UpdateUser(User u)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);


            SqlCommand command = new SqlCommand("usp_UpdateUser", sqlConnection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@UserId", SqlDbType.Int);
            command.Parameters[0].Value = u.UserId;

            command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 500);
            command.Parameters[1].Value = u.FirstName;

            command.Parameters.Add("@SurName", SqlDbType.NVarChar, 500);
            command.Parameters[2].Value = u.Surname;

            command.Parameters.Add("@LastName", SqlDbType.NVarChar, 500);
            command.Parameters[3].Value = u.LastName;

            command.Parameters.Add("@YearOfBirth", SqlDbType.Int);
            command.Parameters[4].Value = u.YearOfBirth;

            sqlConnection.Open();
            command.ExecuteNonQuery();
        }
        public void DeleteUser(User u)
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);


            SqlCommand command = new SqlCommand("usp_DeleteUsers", sqlConnection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@UserId", SqlDbType.Int);
            command.Parameters[0].Value = u.UserId;


            sqlConnection.Open();
            command.ExecuteNonQuery();
        }
    }
}
