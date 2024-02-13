using System.ComponentModel.DataAnnotations;

namespace RaftEscalator.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string? UserFirstName { get; set; }
        public string? UserLastName { get; set; }
        public string? UserEmail { get; set; }
        public string? UserPhone { get; set; }
        public string? UserPassword { get; set;}
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; } = DateTime.MinValue;

    }
}
