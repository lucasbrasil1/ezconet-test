using ezconet_test.Controllers;
using ezconet_test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ezconet_test.Services
{
    public class FilterService
    {

        private IQueryable<Users> list;
        private int Active { get; set; }

        private string Name { get; set; }
        public FilterService(GetUserRequest request)
        {
            if (request.Active != null)
                Active = int.Parse(request.Active);

            if (request.Name != null)
                Name = request.Name;
        }

        internal List<UsersDTO> ExecuteFilter(DbSet<Users> users)
        {

            list = users;

            if (Active == 1)
                list = list.Where(u => u.Active == 1);

            if (Name != null)
                list = list.Where(u => u.Name == Name);

            List<UsersDTO> responseList = new List<UsersDTO>();

            if (list == null)
                return responseList;

            foreach (var user in list)
            {
                responseList.Add(new UsersDTO(user));
            }

            return responseList;
        }
    }
}
