namespace AMA.Persistence.Models
{
    using System.Collections.Generic;

    public class PermissionModel : Model
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<GroupPermissionModel> GroupPermissions { get; set; }
    }
}
