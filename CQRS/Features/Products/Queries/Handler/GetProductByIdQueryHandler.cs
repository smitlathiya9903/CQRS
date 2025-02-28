using MediatR;
using Microsoft.EntityFrameworkCore;
using CQRS.Data;
using CQRS.Models;
using CQRS.Features.Products.Queries;

namespace CQRS.Features.Products.Queries.Handler
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly ApplicationDbContext _context;

        public GetProductByIdQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products
                .FirstOrDefaultAsync(p => p.Id == request.Id, cancellationToken);
        }
    }
}
