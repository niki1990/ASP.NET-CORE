using System.ComponentModel.DataAnnotations;

namespace _Lab_RazorSyntax
{
    public class UserModel
    {
        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        [DataType(DataType.EmailAddress,ErrorMessage ="E-mail Id is not valid")]
        public string Email { get; set; }

    }
}
