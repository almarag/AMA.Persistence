using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AMA.Persistence.Models
{
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
