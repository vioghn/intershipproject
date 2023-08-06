using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Domain.Entities;
using MyProject.Application.Contracts.Repository;
//using MyProject.Domain.Entities;
//using MyProject.Domain.Entities;

using MyProject.Infrastructure.Data;


namespace MyProject.Application.Services
{
    internal class UserService : IUserRepository

    {
        private readonly DemoDbContext dbContext;

        public UserService(DemoDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public string Add(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            return "user added successfully";
        }

        public string Delete(User user)
        {
            dbContext.Users.Remove(user);
            dbContext.SaveChanges();
            return "User deleted";
        }

        public List<User> GetAll()
        {
            return dbContext.Addresss.ToList();
        }

        public User GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public User GetById(int ID)
        {
            throw new NotImplementedException();
        }

        public User GetByRole(Role role)
        {
            throw new NotImplementedException();
        }

        public User GetByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public List<User> GetFavoritesRole(int count)
        {
            throw new NotImplementedException();
        }

        public List<User> GetLatests(int count)
        {
            throw new NotImplementedException();
        }

        public string Update(User user)
        {
            dbContext.Users.Update(user);
            dbContext.SaveChanges();
            return "users updated successfully";
        }
    }
}
