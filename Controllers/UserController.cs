using ezconet_test.Data.Repositories;

using ezconet_test.Errors;
using ezconet_test.Models;
using ezconet_test.Repositories;
using ezconet_test.Services;
using ezconet_test.Services.Validators;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ezconet_test.Controllers
{
    public class UserController : Controller
    {
        private FilterService FilterService;

        private UserContext Context;

        public UserController()
        {
            Context.Database.EnsureCreated();
        }

        [HttpPost("usuario")]
        public async Task<CreateUserResponse> CreateUserAsync([FromBody] CreateUserRequest request) 
        {
            var validationResult = await new UserRequestValidator().ValidateAsync(request);
            this.HttpContext.Response.StatusCode = 400;

            if (!validationResult.IsValid) {
                return new CreateUserResponse(null, validationResult.Errors[0].ToString());
            }

            var user = new Users(request);
            Context.User.Add(user);

            if (Context.SaveChanges() != 1)
                return new CreateUserResponse(null, EzconetErrors.Ezconet_400_Unable_To_Register_User.ToString());

            this.HttpContext.Response.StatusCode = 200;
            return new CreateUserResponse(user.Id, null);
        }

        [HttpGet("usuarios")]
        public GetUserResponse GetUserListAsync([FromQuery] GetUserRequest request)
        {
            var users = Context.User;
            FilterService = new FilterService(request);

            if (users.Count() == 0)
                return new GetUserResponse(null, EzconetErrors.Ezconet_400_Database_No_Records_Found.ToString());

            List<UsersDTO> filteredList = FilterService.ExecuteFilter(users);



            return filteredList.Count() == 0 ?
                new GetUserResponse(null, EzconetErrors.Ezconet_400_Database_No_Records_Found.ToString())
                : new GetUserResponse(filteredList, null);
        }
    }
}
