using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyProject.Domain.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int addressID { get; set; }
        public Address Address { get; set; }
        public Role Role { get; set; } //  one role can be for N users but I considered that one user can just have one role so the relation is 1 to N.
    }
}
