using System.ComponentModel;

namespace ezconet_test.Errors
{
    public enum EzconetErrors
    {
        [Description("Nome não pode ser vazio.")]
        Ezconet_400_Name_Can_Not_Be_Null_Or_Empty,

        [Description("Nome deve conter mais de três caracteres.")]
        Ezconet_400_Name_Must_Be_Above_Three_Characters,

        [Description("Data de nascimento não pode ser vazia.")]
        Ezconet_400_BirthDate_Can_Not_Be_Null_Or_Empty,

        [Description("Email não pode ser vazio.")]
        Ezconet_400_Email_Can_Not_Be_Null_Or_Empty,

        [Description("Gênero não pode ser vazio.")]
        Ezconet_400_Gender_Can_Not_Be_Null_Or_Empty,

        [Description("Gênero deve ser M (Masculino) ou F (Feminino).")]
        Ezconet_400_Gender_Must_Be_Male_Or_Female,

        [Description("Não foi possível cadastrar o usuário. [Database Error]")]
        Ezconet_400_Unable_To_Register_User,

        [Description("Data de nascimento deve ser válida (dd/mm/aaaa).")]
        Ezconet_400_Date_Must_Be_Valid,

        [Description("O campo Active deve ser 1 (ativo) ou 0 (inativo).")]
        Ezconet_400_Active_Must_Be_One_Or_Zero,

        [Description("Banco de dados sem registros.")]
        Ezconet_400_Database_No_Records_Found
    }
}
