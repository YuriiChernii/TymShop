using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tymchak_shop.Data.Interfaces;
using Tymchak_shop.Data.Models;

namespace Tymchak_shop.Data.Mocks
{
    public class MockShoes : IAllShoes
    {
        private readonly IShoesCategory _shoesCategory = new MockCategory();
        public IEnumerable<Shoes> Shoes 
        {
            get {
                return new List<Shoes>
                {
                    new Shoes
                    {
                        name = "Nike-1", 
                        longDescription = "", 
                        shortDescription = "sdfgd", 
                        image = "/img/Nike_1.png", 
                        price = 500, 
                        isFavourite = true,  
                        available = true,
                        Category = _shoesCategory.AllCategories.First()
                    },
                    new Shoes
                    {
                        name = "Gucci",
                        longDescription = "",
                        shortDescription = "",
                        image = "/img/Gucci.jpg", 
                        price = 1000,
                        isFavourite = true,
                        available = true,
                        Category = _shoesCategory.AllCategories.Last()
                    },
                    new Shoes
                    {
                        name = "Nike-2",
                        longDescription = "",
                        shortDescription = "",
                        image = "/img/Nike_2.webp", 
                        price = 600,
                        isFavourite = true,
                        available = true,
                        Category = _shoesCategory.AllCategories.First()
                    },
                    new Shoes
                    {
                        name = "Adidas",
                        longDescription = "",
                        shortDescription = "",
                        image = "/img/Gucci.jpg", 
                        price = 550,
                        isFavourite = true,
                        available = true,
                        Category = _shoesCategory.AllCategories.First()
                    }

                };
            }
            
        }
        public IEnumerable<Shoes> getFavShoes { get; set; }

        public Shoes getObjectShoes(int shoesID)
        {
            throw new NotImplementedException();
        }
    }
}
