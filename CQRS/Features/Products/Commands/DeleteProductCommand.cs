using MediatR;

namespace CQRS.Features.Products.Commands
{
    public record DeleteProductCommand(int Id) : IRequest<bool>;

}
