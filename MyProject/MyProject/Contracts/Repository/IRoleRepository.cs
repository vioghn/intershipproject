using MyProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Application.Contracts.Repository
{
    internal interface IRoleRepository
    {
        public Role GeybyID(int ID);
        public Role GeybyName(string Name);
        public List<Role> GetAllRoles();
        void Add(Role role);
        void Update(Role role);
        void Delete(Role role);
        
        
    }
}
