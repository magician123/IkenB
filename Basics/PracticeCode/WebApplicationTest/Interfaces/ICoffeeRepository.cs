using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationTest.Models;

namespace WebApplicationTest.Interfaces
{
    public interface ICoffeeRepository
    {
        IEnumerable<Coffee> GetAllCoffees();
        Coffee GetCoffeById(int coffeeId);

    }
}
