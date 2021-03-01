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
