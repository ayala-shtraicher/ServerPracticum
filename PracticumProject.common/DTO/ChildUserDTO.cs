using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticumProject.common.DTO
{
    public class ChildUserDTO
    {
        [Key, Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tz { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int ParentId { get; set; }
        public override string ToString()
        {
            return $" name : {Name} tz : {Tz} date of birth day: {DateOfBirth} ";
        }
        public ChildUserDTO()
        {

        }
        public ChildUserDTO(string name,string tz, DateTime dateOfBirth, int id, int parentId)
        {
            Name = name;
            Tz= tz;
            DateOfBirth = dateOfBirth;
            Id = id;
            ParentId = parentId;
        }
    }
}
