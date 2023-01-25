using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Application.Products.Queries.GetProductsList
{
    public class ProductsListVm
    {
        public IList<MenuLookupDto> Products { get; set; }
    }
}
