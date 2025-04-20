using Domain.Entities;

namespace Application.Interfaces
{
    public interface IXmlImportService
    {
        IEnumerable<Division> ImportDivisions(string xmlData);
    }
}