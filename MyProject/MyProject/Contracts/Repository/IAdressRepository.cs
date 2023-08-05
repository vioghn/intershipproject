using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProject.Domain.Entities;



namespace MyProject.Application.Contracts.Repository
{
    internal interface IAdressRepository
    {
        public Address GetById(int Id);
        public Address GetByCity(string City);
        public List<Address> GetAll();
        public void Add (Address address);
        public void Update (Address address);
        public void Delete (Address address);


    }
}
