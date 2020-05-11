using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTest.Interfaces;

namespace WebApplicationTest.Models
{
    public class CoffeeRepository : ICoffeeRepository
    {
        private List<Coffee> _coffees;
        public CoffeeRepository()
        {
            if(_coffees ==null)
            {
                InitializeCoffees();
            }
        }

        private void InitializeCoffees()
        {
            _coffees = new List<Coffee>
            {
                new Coffee{Id=1, Name="Mochacho", Description="The italian made"},
                new Coffee{Id=2, Name="Cuppucinno", Description="The Irish made"},
                new Coffee{Id=3, Name="Caffe Latte", Description="The South african made"}

            };
        }

        public IEnumerable<Coffee> GetAllCoffees()
        {
            return _coffees;
        }

        public Coffee GetCoffeById(int coffeeId)
        {
            return _coffees.FirstOrDefault(c => c.Id == coffeeId);
        }
    }
}
