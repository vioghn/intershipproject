using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Application.Contracts.Repository;
//using MyProject.Domain.Entities;
//using MyProject.Domain.Entities;
using MyProject.Domain.Entities;
using MyProject.Infrastructure.Data;
//using MyProject.Infrastructure.Data.Entities;



namespace MyProject.Application.Services
{
    internal class AddressServices : IAdressRepository
    {

        private readonly DemoDbContext dbContext;

        public AddressServices(DemoDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Address GetById(int Id)
        {
            return dbContext.Addresss.Where(x => x.AddressId == Id).FirstOrDefault();
        }
        public Address GetByCity(string City)
        {
           return dbContext.Addresss.Where(x => x.City == City).FirstOrDefault();

        }

    public List<Address> GetAll()
    {
            return dbContext.Addresss.ToList();
        }
    public string Add(Address address)
    {
            dbContext.Addresss.Add(address);
            dbContext.SaveChanges();
            return "Address added successfully";
        }
        public string Update(Address address)
    {
            dbContext.Addresss.Update(address);
            dbContext.SaveChanges();
            return "Address added successfully";
        }
        public string Delete(Address address)
    {
            dbContext.Addresss.Remove(address);
            dbContext.SaveChanges();
            return "User deleted";
        }

        Domain.Entities.Address IAdressRepository.GetById(int Id)
        {
            throw new NotImplementedException();
        }

    }
}
