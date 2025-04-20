using Domain.Entities;
using Domain.Interfaces;
using Persistence.DataContext;

namespace Persistence.Repositories
{
    /// <summary>
    /// Реализация через Postgres.
    /// </summary>
    public class PostgresDivisionRepository : IDivisionRepository
    {
        private readonly AppDbContext _context;
        public PostgresDivisionRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Division> GetAllDivisions()
        {
            throw new NotImplementedException();
        }

        public Division? GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Add(Division division)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Division division)
        {
            throw new NotImplementedException();
        }
    }
}
