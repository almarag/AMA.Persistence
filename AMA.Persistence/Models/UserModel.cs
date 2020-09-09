namespace AMA.Persistence.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class UserModel : Model
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        [ForeignKey("PersonId")]
        public PersonModel PersonModel { get; set; }
        public ICollection<UserGroupModel> UserGroups { get; set; }
    }
}
