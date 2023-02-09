using PracticumProject.common.DTO;
using System.ComponentModel.DataAnnotations;

namespace PracticumProject.WebAPI.Models
{
    public class UserModel
    {
        [Key,Required]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }

        public DateTime DateOfBirth { get; set; }
        public EGenderDTO egender { get; set; }
        public string HMO { get; set; }
    }
}
