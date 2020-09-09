namespace AMA.Persistence.Models
{
    public class UserGroupModel
    {
        public int UserId { get; set; }
        public UserModel UserModel { get; set; }
        public int GroupId { get; set; }
        public GroupModel GroupModel { get; set; }
    }
}
