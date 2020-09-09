using System.Collections;
using System.Collections.Generic;

namespace AMA.Persistence.Models
{
    public class GroupModel : Model
    {
        public string Name { get; set; }
        public ICollection<UserGroupModel> UserGroups { get; set; }
    }
}
