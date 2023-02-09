using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticumProject.common.DTO
{
    public enum EGenderDTO { male, female };
    public class UserDTO
    {
        [Key,Required]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tz { get; set; }

        public DateTime DateOfBirth { get; set; }
        public EGenderDTO egenderDTO { get; set; }
        public string HMO { get; set; }
        public override string ToString()
        {
            return $" name : {FirstName} {LastName} tz : {Tz} date of birth day : {DateOfBirth} gender : {egenderDTO} HMO : {HMO} ";
        }
        public UserDTO()
        {

        }
        public UserDTO(string firstName, string lastName,string tz, int id, DateTime dateOfBirth, EGenderDTO egenderDTO, string hMO)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Tz= tz;
            DateOfBirth = dateOfBirth;
            this.egenderDTO = egenderDTO;
            HMO = hMO;
        }
       
    }
}
