﻿namespace AMA.Persistence.Models
{
    using System.Collections.Generic;

    public class GroupModel : Model
    {
        public string Name { get; set; }
        public ICollection<UserGroupModel> UserGroups { get; set; }
        public ICollection<GroupPermissionModel> GroupPermissions { get; set; }
    }
}
