using CQRS.Models;
using MediatR;

namespace CQRS.Features.Products.Queries
{
    public record GetAllProductsQuery : IRequest<IEnumerable<Product>>;
}

