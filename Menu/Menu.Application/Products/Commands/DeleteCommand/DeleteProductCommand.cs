using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Menu.Application.Products.Commands.DeleteCommand
{
    public class DeleteProductCommand : IRequest
    {
        public Guid MenuId { get; set; }
        public Guid Id { get; set; }
    }
}
