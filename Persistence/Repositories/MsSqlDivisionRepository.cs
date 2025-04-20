using Domain.Entities;
using Domain.Interfaces;
using Persistence.DataContext;

namespace Persistence.Repositories
{
    /// <summary>
    /// Реализация через MsSql.
    /// </summary>
    public class MsSqlDivisionRepository : IDivisionRepository
    {
        private readonly AppDbContext _context;
        public MsSqlDivisionRepository(AppDbContext context)
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
        
        // При SaveChanges БД кинет ошибку при конкурентном изменении.
        // catch (DbUpdateConcurrencyException ex)
        // {
        //     throw new ConcurrencyException("Данные уже изменены другим пользователем. Обновите данные.", ex);
        // }
    }
}
