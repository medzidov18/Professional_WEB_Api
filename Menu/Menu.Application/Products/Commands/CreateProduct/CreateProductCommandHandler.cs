using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Menu.Application.Interfaces;

namespace Menu.Application.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
    {
        private readonly IMenuDbContext _dbContext;

        public CreateProductCommandHandler(IMenuDbContext dbContext) => _dbContext = dbContext;

        public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Domain.Menu
            {
                MenuId = request.MenuId,
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                Id = new Guid(),
                CreationDate = DateTime.Now,
                EditDate = null
            };

            await _dbContext.Menus.AddAsync(product, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return product.Id;
        }
    }
}
