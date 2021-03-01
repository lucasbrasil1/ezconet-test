namespace ezconet_test.Models
{
    public class UsersDTO
    {
        public UsersDTO(Users user)
        {
            Name = user.Name;
            BirthDate = user.BirthDate.ToString();
            Email = user.Email;
            Gender = user.Gender;
            Active = user.Active == 1 ? "Sim" : "Não";
        }

        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Active { get; set; }
    }
}
