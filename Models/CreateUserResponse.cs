using ezconet_test.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ezconet_test.Models
{
    public class CreateUserResponse : Response
    {
        public CreateUserResponse(object body, string errors)
        {
            this.Body = body;
            this.Errors = errors;
        }
    }
}
