
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticumProject.WebAPI.Models
{
    public class ChildUserModel
    {
        [Key,Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tz { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int ParentId { get; set; }
    }
}
