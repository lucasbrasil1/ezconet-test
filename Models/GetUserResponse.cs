using ezconet_test.Errors;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ezconet_test.Models
{
    public class GetUserResponse : Response
    {
        public GetUserResponse(List<UsersDTO> list, string errors)
        {
            this.Body = list;
            this.Errors = errors;
        }
    }
}
