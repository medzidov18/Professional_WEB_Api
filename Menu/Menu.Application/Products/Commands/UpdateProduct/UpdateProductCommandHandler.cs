using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Menu.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Menu.Application.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IMenuDbContext _dbContext;

        public UpdateProductCommandHandler(IMenuDbContext dbContext) => _dbContext = dbContext;

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Menus.FirstOrDefaultAsync(product => product.Id == request.Id, cancellationToken)

            return Unit.Value;
        }
    }
}
