using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modellen;

namespace DAL
{
    interface ICoffeeRepository
    {
        void DeleteCoffee(string coffee);
        Coffee GetACoffee(string coffeeName);
        Coffee GetCoffeeById(int coffeeid);
        List<Coffee> GetCoffees();
        void UpdateCoffee(Coffee coffee);
        void LoadCoffees();
    }
}
