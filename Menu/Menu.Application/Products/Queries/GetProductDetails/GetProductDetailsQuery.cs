using System; 
using MediatR;

namespace Menu.Application.Products.Queries.GetProductDetails
{
    public class GetProductDetailsQuery : IRequest<ProductDetailsVm>
    {
        public Guid MenuId { get; set; }
        public Guid Id { get; set; }
    }
}
