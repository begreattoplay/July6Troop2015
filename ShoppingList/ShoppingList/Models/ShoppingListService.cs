using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingList.Models
{
    public class ShoppingListService
    {
        public IList<Product> GetItems()
        {
            return new List<Product>
            {
                new Product { Name = "Peanut Butter", Price = 3.99m },
                new Product { Name = "Popcorn", Price = 2.79m }
            };
        }
    }
}