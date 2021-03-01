using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ezconet_test.Repositories
{
    public class MySqlDatabase : DbContext
    {
        public MySqlConnection Connection;
        public string connectionString = "server=localhost;database=ezconet;user=root;";

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseMySQL(connectionString);
        }

    }
}
