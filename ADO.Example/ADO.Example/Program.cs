using System;
using System.Data.SqlClient;

namespace ADO.Example
{
    class Program
    {
        static void Main(string[] args)
        {

            //SqlConnection connection = new SqlConnection("Server=DESKTOP-SCH63NU\\SQLEXPRESS;Database=Task2;Integrated Security=True");

            //connection.Open();

            //using (connection)
            //{
            //    SqlCommand comm = new SqlCommand(" SELECT * FROM Users", connection);    //*(" SELECT FirstName, LastName FROM Users",connection);*/
            //    SqlDataReader reader = comm.ExecuteReader();
            //    using(reader)
            //    {
            //        int count = 0;
            //        while(reader.Read())
            //        {
            //            Console.WriteLine("----------------");
            //            for (int i = 0; i < reader.VisibleFieldCount; i++)
            //            {
            //                Console.WriteLine(reader[i]);
            //            }
            //            //var firsName = reader["FirstName"];
            //            //var lastName = reader["LastName"];
            //            //Console.WriteLine($"{firsName} +  {lastName}");
            //            count++;

            //        }
            //        Console.WriteLine($" NUmber of Users: {count}");
            //    }

            //}
            //Console.WriteLine("Connection closed!");

            var newUser = new User();
            newUser.FirstName = "Geshevvvvvv";
            newUser.Surname = "123456";
            newUser.LastName = "Test VAlio";
            newUser.YearOfBirth = 1992;
            var addUser = new UserRepository();
            addUser.InsertUser(newUser);

            var newUser2 = new User();
            newUser2.UserId = 2;
            newUser2.FirstName = "Bat";
            newUser2.Surname = "Boyko";
            newUser2.LastName = "BorisoF";
            newUser2.YearOfBirth = 1958;

            var addUser2 = new UserRepository();
            addUser2.UpdateUser(newUser2);

            var user3 = new User();
            user3.UserId = 2;
            var deluser = new UserRepository();
            deluser.DeleteUser(user3);
          
           
            
        }

    }
}


