using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Menu.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Menu.Application.Products.Queries.GetProductsList
{
    public class GetProductsListQueryHandler : IRequestHandler<GetProductsListQuery, ProductsListVm>
    {
        private readonly IMenuDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetProductsListQueryHandler(IMenuDbContext dbContext, IMapper mapper)
            => (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<ProductsListVm> Handle(GetProductsListQuery request, CancellationToken cancellationToken)
        {
            var productsQuery = await _dbContext.Menus
                .Where(product => product.MenuId == request.MenuId)
                .ProjectTo<MenuLookupDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new ProductsListVm { Products = productsQuery };
        }
    }
}
