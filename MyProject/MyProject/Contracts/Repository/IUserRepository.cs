using MyProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Application.Contracts.Repository
{
    internal interface IUserRepository
    {
        public User GetById(int ID);
        public List<User> GetAll();
        public User GetByRole(Role role);
        public User GetByUserName(string userName);
        public User GetByEmail(string email);
        public List<User> GetLatests(int count);// tell the 10 recently useres which are added to phonebook 
        public List<User> GetFavoritesRole(int count); //which role has the most users-adding in the last month 
        public void Update(int ID);
        public void Delete(int ID);
        public void Add(User user);

    }
}
