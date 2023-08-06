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
        public string Add (Address address);
        public string Update (Address address);
        public string Delete (Address address);


    }
}
