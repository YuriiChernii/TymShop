using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tymchak_shop.Data.Interfaces;
using Tymchak_shop.Data.Models;

namespace Tymchak_shop.Data.Mocks
{
    public class MockCategory : IShoesCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get {
                return new List<Category>
                {
                    new Category{name = "sneakers", description = "modern and comfortable"},
                    new Category{name = "heels", description="trendy"}
                };
            }
        }
    }
}
