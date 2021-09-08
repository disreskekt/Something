using Something.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Something.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string Surname { get; set; }
        //public string Login { get; set; }
        //public string Password { get; set; }
        //public DateTime CreationDate { get; set; }
        //public DateTime BirthDate { get; set; }
        //public bool IsOnline { get; set; }
        //public bool IsDeleted { get; set; }
        
        //navigation fields
        public Role UserRoleId { get; set; }
        public UserRole UserRole { get; set; }
    }
}
