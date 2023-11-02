using System.ComponentModel.DataAnnotations;

namespace ObsługaFormularzyDawidD.Models
{
    public class Data
    {
        [Required(ErrorMessage = "Please fill your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please fill your e-mail address")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        
        
    }
}

