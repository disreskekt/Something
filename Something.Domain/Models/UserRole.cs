using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Something.Domain.Models
{
    public class UserRole
    {
        public Role Id { get; set; }
        public string Name { get; set; }

        //navigation
        public virtual ICollection<User> User { get; set; }
    }
}
