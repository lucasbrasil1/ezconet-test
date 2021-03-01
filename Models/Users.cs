using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ezconet_test.Models
{
    public class Users
    {
        public Users(CreateUserRequest user)
        {
            Id = user.Id;
            Name = user.Name;
            BirthDate = DateTime.Parse(user.BirthDate);
            Email = user.Email;
            Password = user.Password;
            Gender = user.Gender;
            Active = user.Active;
        }

        public Users()
        {

        }

        public int Id { get; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public int Active { get; set; }
    }
}
