namespace AMA.Persistence.Models
{
    using System.ComponentModel.DataAnnotations;

    public class PersonModel : Model
    {
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        [Required]
        public string PhoneNumber { get; set; }
    }
}
