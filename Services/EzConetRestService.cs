using ezconet_test.Controllers;
using ezconet_test.Models;
using ezconet_test.Repositories;
using MySql.Data.MySqlClient;
using System;

namespace ezconet_test.Services
{
    public class EzConetRestService
    {
        
        //public EzConetRestService(MySqlDatabase mySqlDatabase)
        //{
        //    this.MySqlDatabase = mySqlDatabase;
        //}

        //public bool CreateUser(CreateUserRequest user)
        //{
            
        //}

        //public void GetUsers(GetUserRequest request)
        //{
        //    var cmd = this.MySqlDatabase.Connection.CreateCommand() as MySqlCommand;

        //    cmd.CommandText = @"SELECT user_name, birth_date, email, gender, active FROM users WHERE user_name = @UserName AND active = @Active";
        //    cmd.Parameters.AddWithValue("@Active", request.Active);
        //    cmd.Parameters.AddWithValue("@UserName", request.Name);

        //    var records = cmd.ExecuteReader();
        //    Console.WriteLine(records);
        //}
    }
}
