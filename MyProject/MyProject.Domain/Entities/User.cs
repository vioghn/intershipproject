using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string mobile { get; set; }
        public Address address { get; set; }
        public Role role { get; set; } //  one role can be for N users but I considered that one user can just have one role so the relation is 1 to N.
    }
}
