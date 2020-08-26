using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modellen;

namespace DAL
{
    public class CoffeeRepository : ICoffeeRepository
    {
        public List<Coffee> coffees { get; set; }

        public void DeleteCoffee(string coffee)
        {
            foreach (Coffee hvercoffee in coffees)
            {
                if(coffee == hvercoffee.CoffeeName)
                {
                    coffees.Remove(hvercoffee);
                    break;
                }
            }
        }

        public Coffee GetACoffee(string coffeeName)
        {
            Coffee FundetCoffee = coffees.Find(coffee => coffee.CoffeeName == coffeeName);
            return FundetCoffee;
        }

        public Coffee GetCoffeeById(int coffeeid)
        {
            //foreach (Coffee id in coffees)
            //{
            //    if(coffeeid == id.CoffeeId)
            //    {
            //        return id;
            //    }
            //}
            //return new Coffee();

            Coffee FundetCoffee = coffees.Find(coffee => coffee.CoffeeId == coffeeid);
            return FundetCoffee;
        }

        public List<Coffee> GetCoffees()
        {
            return coffees;
        }

        public void LoadCoffees()
        {
            coffees = new List<Coffee>()
            {
                new Coffee ()
                {
                    CoffeeId = 1,
                    CoffeeName = "Gill's home-made latte",
                    Description = "Simply the best lattes in the world, with a little bit of hazelnut syrup!",
                    ImageId = 1,
                    AmountInStock=10,
                    InStock = true,
                    FirstAddedToStockDate = new DateTime(2014,1,3),
                    OriginCountry = Country.Ethiopia,
                    Price = 12
                },
                new Coffee ()
                {
                    CoffeeId = 2,
                    CoffeeName = "Espresso",
                    Description = "Espresso is a strong black coffee made by forcing steam through dark-roast aromatic coffee beans at high pressure in an espresso machine. A perfectly brewed espresso will have a thick, golden-brown crema (foam) on the surface. If the crema is good, the sugar you add will float on the surface for a couple of seconds before slowly sinking to the bottom.",
                    ImageId = 2,
                    InStock = true,
                    AmountInStock=100,
                    FirstAddedToStockDate = new DateTime(2015,10,3),
                    OriginCountry = Country.Colombia,
                    Price = 12
                },
                new Coffee ()
                {
                    CoffeeId = 3,
                    CoffeeName = "Capuccino coffee",
                    Description = "This hugely popular coffee drink has become a staple that even the most common of corner coffee shops carries (or at least a version of it). A true cappuccino is a combination of equal parts espresso, steamed milk and milk froth. This luxurious drink, if made properly, can double as a dessert with its complex flavors and richness.",
                    ImageId = 3,
                    InStock = true,
                    AmountInStock=0,
                    FirstAddedToStockDate = new DateTime(2014,5,5),
                    OriginCountry = Country.Ecuador,
                    Price = 12
                },
                new Coffee ()
                {
                    CoffeeId = 4,
                    CoffeeName = "Americano",
                    Description = "An Americano is a single shot of espresso added to a cup of hot water. The name is thought to have originated as a bit of an insult to Americans, who had to dilute their espresso when it first gained popularity on this side of the pond. Many coffee houses have perfected it, however, and the result has become a creamy, rich espresso-based coffee that you can sip and savor before jumping on your Vespa and heading to the soccer field.",
                    ImageId = 4,
                    InStock = true,
                    AmountInStock=200,
                    FirstAddedToStockDate = new DateTime(2013,9,9),
                    OriginCountry = Country.India,
                    Price = 14
                },
                new Coffee ()
                {
                    CoffeeId = 5,
                    CoffeeName = "Caffe Latte",
                    Description = "A caffe latte is a single shot of espresso to three parts of steamed milk.",
                    ImageId = 5,
                    InStock = true,
                    AmountInStock=0,
                    FirstAddedToStockDate = new DateTime(2013,9,9),
                    OriginCountry = Country.India,
                    Price = 9
                },
                new Coffee ()
                {
                    CoffeeId = 6,
                    CoffeeName = "Cafe au Lait",
                    Description = "This traditional French drink is similar to a caffe latte except that it is made with brewed coffee instead of espresso, in a 1:1 ratio with steamed milk. It is considered a weaker form of caffe latte.",
                    ImageId = 6,
                    InStock = false,
                    AmountInStock=8,
                    FirstAddedToStockDate = new DateTime(2013,9,9),
                    OriginCountry = Country.India,
                    Price = 11
                },
                new Coffee ()
                {
                    CoffeeId = 7,
                    CoffeeName = "Cafe Mocha",
                    Description = "This is a cappuccino or a caffe latte with chocolate syrup or powder added. There can be wide variations in exactly how this is prepared, so ask your coffee house how they do it before you order.",
                    ImageId = 7,
                    InStock = true,
                    AmountInStock=1000,
                    FirstAddedToStockDate = new DateTime(2013,9,9),
                    OriginCountry = Country.Ethiopia,
                    Price = 10
                },
                new Coffee ()
                {
                    CoffeeId = 8,
                    CoffeeName = "Caramel Macchiato",
                    Description = "This is another variation that is prepared in a number of ways by different coffee houses. The most common method is combining espresso, caramel and foamed milk, though some use steamed milk. Often, vanilla is added to provide extra flavor.",
                    ImageId = 8,
                    InStock = true,
                    AmountInStock=200,
                    FirstAddedToStockDate = new DateTime(2013,9,9),
                    OriginCountry = Country.Honduras,
                    Price = 11
                }
            };
        }

        public void UpdateCoffee(Coffee coffee)
        {
            throw new NotImplementedException();
        }

        public void CreateCoffee(string coffeeName, string description, int imageId, bool inStock, int amountInStock, DateTime firstAddedToStockDate, Country originCountry, int price)
        {
            Coffee newCoffee = new Coffee();
            newCoffee.CoffeeId = coffees.Count + 1;
            newCoffee.CoffeeName = coffeeName;
            newCoffee.Description = description;
            newCoffee.ImageId = imageId;
            newCoffee.InStock = inStock;
            newCoffee.AmountInStock = amountInStock;
            newCoffee.FirstAddedToStockDate = firstAddedToStockDate;
            newCoffee.OriginCountry = originCountry;
            newCoffee.Price = price;

            coffees.Add(newCoffee);
        }
    }
}
