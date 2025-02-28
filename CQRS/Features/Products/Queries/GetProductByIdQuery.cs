using MediatR;
using CQRS.Models;

namespace CQRS.Features.Products.Queries
{
    public record GetProductByIdQuery(int Id) : IRequest<Product>;

}
