using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticumProject.Repositories.Entities
{
    public class ChildUser
    {
        [Key, Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tz { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int ParentId { get; set; }
        public ChildUser()
        {

        }
        public ChildUser(string name,string tz, DateTime dateOfBirth, int id, int parentId)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Id = id;
            Tz= tz;
            ParentId = parentId;
           // Parent = parent;
        }
        public ChildUser(ChildUser childUser)
        {
            Name = childUser.Name;
            Id = childUser.Id;
            Tz= childUser.Tz;
            ParentId = childUser.ParentId;
           // Parent = childUser.Parent;
        }
    }
}
