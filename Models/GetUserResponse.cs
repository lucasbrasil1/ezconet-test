using System.Collections.Generic;

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
