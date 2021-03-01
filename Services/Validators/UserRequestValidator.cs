using ezconet_test.Errors;
using ezconet_test.Models;
using FluentValidation;

namespace ezconet_test.Services.Validators
{
    public class UserRequestValidator : AbstractValidator<CreateUserRequest>
    {
        private const string DateRegexExpression = @"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$";

        public UserRequestValidator()
        {

            RuleFor(c => c.Name)
                .NotEmpty()
                .WithMessage(EzconetErrors.Ezconet_400_Name_Can_Not_Be_Null_Or_Empty.ToString())
                .Must(c => IsAboveThreeCharacters(c))
                .WithMessage(EzconetErrors.Ezconet_400_Name_Must_Be_Above_Three_Characters.ToString());

            RuleFor(c => c.BirthDate)
                .NotEmpty()
                .WithMessage(EzconetErrors.Ezconet_400_BirthDate_Can_Not_Be_Null_Or_Empty.ToString())
                .Matches(DateRegexExpression)
                .WithMessage(EzconetErrors.Ezconet_400_Date_Must_Be_Valid.ToString());

            RuleFor(c => c.Email)
                .NotEmpty()
                .WithMessage(EzconetErrors.Ezconet_400_Email_Can_Not_Be_Null_Or_Empty.ToString());


            RuleFor(c => c.Gender)
                .NotEmpty()
                .WithMessage(EzconetErrors.Ezconet_400_Gender_Can_Not_Be_Null_Or_Empty.ToString())
                .Must(c => IsMaleOrFemale(c))
                .WithMessage(EzconetErrors.Ezconet_400_Gender_Must_Be_Male_Or_Female.ToString());

            RuleFor(c => c.Active)
                .Must(c => IsOneOrZero(c))
                .WithMessage(EzconetErrors.Ezconet_400_Active_Must_Be_One_Or_Zero.ToString());

        }

        private bool IsMaleOrFemale(string c)
        {
            return c == "M" || c == "F";
        }

        private bool IsAboveThreeCharacters(string name)
        {
            return name.Trim().Length >= 3;
        }

        private bool IsOneOrZero(int active)
        {
            return active == 1 || active == 0;
        }
    }
}
