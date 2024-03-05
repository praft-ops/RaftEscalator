namespace RaftEscalator.Models
{
    public class OrganizationModel
    {
        //Primary Key
        public int OrgId { get; set; }
        public string? OrgName { get; set; }
        public string? OrganizationPhone { get; set; }
        public string? OrganizationEmail { get; set; }
        public DateTime CreatedDate { get; set; }  
        public DateTime? LastModifiedDate { get; set; }

    }
}
