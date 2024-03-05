namespace RaftEscalator.Models
{
    public class OrganizationModel
    {
        public int OrgId { get; set; }
        public string? OrgName { get; set; }
        public string? OrganizationPhone { get; set; }
        public string? OrganizationEmail { get; set; }
        public DateTime CreatedDate { get; set; }  
        public DateTime? LastModifiedDate { get; set; }

        // Foregin Keys

        //Define one-to-many relationship for groups

        public ICollection<GroupModel> Groups { get; set; }
        
        // Define a one-to-many relationship for users

        public ICollection<UserModel> Users { get; set; }

        // Define a one-to-many relationship for issues

        public ICollection<IssueModel> Issues { get; set; }

    }
}
