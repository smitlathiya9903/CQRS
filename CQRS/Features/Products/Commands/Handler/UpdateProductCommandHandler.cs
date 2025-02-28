using MediatR;
using CQRS.Models;
using CQRS.Data;

namespace CQRS.Features.Products.Commands.Handler
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly ApplicationDbContext _context;

        public UpdateProductCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _context.Products.FindAsync(new object[] { request.Id }, cancellationToken);

            if (product == null)
                return false;

            product.Name = request.Name;
            product.Price = request.Price;

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
