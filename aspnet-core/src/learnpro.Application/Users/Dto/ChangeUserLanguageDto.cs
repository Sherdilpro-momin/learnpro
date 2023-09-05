using System.ComponentModel.DataAnnotations;

namespace learnpro.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}