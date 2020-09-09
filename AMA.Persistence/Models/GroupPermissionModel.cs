namespace AMA.Persistence.Models
{
    public class GroupPermissionModel
    {
        public int GroupId { get; set; }
        public GroupModel GroupModel { get; set; }
        public int PermissionId { get; set; }
        public PermissionModel PermissionModel { get; set; }
    }
}
