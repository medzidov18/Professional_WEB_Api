using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Menu.Application.Common.Exceptions;
using Menu.Application.Interfaces;

namespace Menu.Application.Products.Commands.DeleteCommand
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly IMenuDbContext _dbContext;

        public DeleteProductCommandHandler(IMenuDbContext dbContext) => _dbContext = dbContext;

        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Menus.FindAsync(new object[] {request.Id}, cancellationToken);

            if (entity == null || entity.MenuId != request.MenuId)
            {
                throw new NotFoundException(nameof(Domain.Menu), request.Id);
            }

            _dbContext.Menus.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
