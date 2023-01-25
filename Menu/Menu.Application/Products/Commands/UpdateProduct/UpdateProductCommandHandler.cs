using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Menu.Application.Common.Exceptions;
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
            var entity =
                await _dbContext.Menus.FirstOrDefaultAsync(product => product.Id == request.Id, cancellationToken);

            if (entity == null || entity.MenuId != request.MenuId)
            {
                throw new NotFoundException(nameof(Domain.Menu), request.Id);
            }

            entity.Name = request.Name;
            entity.Description = request.Description;
            entity.Price = request.Price;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
