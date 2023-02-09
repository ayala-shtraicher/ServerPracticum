using System.ComponentModel.DataAnnotations;

namespace PracticumProject.Repositories.Entities
{
    public enum EGender { male=1, female=2 }
    public class User
    {
        [Key, Required]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }

        public DateTime DateOfBirth { get; set; }
        public EGender egender { get; set; }
        public string HMO { get; set; }
        public User()
        {

        }
        public User(string firstName, string lastName,string tz, int id, DateTime dateOfBirth, EGender egender, string hMO)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Tz= tz; 
            DateOfBirth = dateOfBirth;
            this.egender = egender;
            HMO = hMO;
        }
       public User(User user)
        {
            FirstName = user.FirstName;
            LastName = user.LastName;
            Id = user.Id;
            Tz= user.Tz;
            DateOfBirth = user.DateOfBirth;
            egender = user.egender;
            HMO = user.HMO;
        }
    }
}