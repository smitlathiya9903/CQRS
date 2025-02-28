using MediatR;
using Microsoft.EntityFrameworkCore;
using CQRS.Data;
using CQRS.Models;
using CQRS.Features.Products.Queries;

namespace CQRS.Features.Products.Queries.Handler
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
    {
        private readonly ApplicationDbContext _context;

        public GetAllProductsQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.ToListAsync(cancellationToken);
        }
    }
}
