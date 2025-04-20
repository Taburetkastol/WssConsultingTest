using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IDivisionRepository
    {
        IEnumerable<Division> GetAllDivisions();

        Division? GetById(Guid id);

        void Add(Division division);
        
        void Delete(Guid id);

        void Update(Division division);
    }
}