using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Menu.Application.Common.Exceptions;
using Menu.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Menu.Application.Products.Queries.GetProductDetails
{
    public class GetProductDetailsQueryHandler : IRequestHandler<GetProductDetailsQuery, ProductDetailsVm>
    {
        private readonly IMenuDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetProductDetailsQueryHandler(IMenuDbContext dbContext, IMapper mapper) =>
            (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<ProductDetailsVm> Handle(GetProductDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Menus.FirstOrDefaultAsync(product => product.Id == request.Id, cancellationToken);

            if (entity == null || entity.Id != request.Id)
            {
                throw new NotFoundException(nameof(Domain.Menu), request.Id);
            }

            return _mapper.Map<ProductDetailsVm>(entity);
        }
    }
}
