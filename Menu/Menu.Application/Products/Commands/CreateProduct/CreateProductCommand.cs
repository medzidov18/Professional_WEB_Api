using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Menu.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommand : IRequest<Guid>
    {
        public Guid MenuId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
