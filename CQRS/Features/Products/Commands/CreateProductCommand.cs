using MediatR;

namespace CQRS.Features.Products.Commands
{
    public record CreateProductCommand(string Name, decimal Price) : IRequest<int>;

}
