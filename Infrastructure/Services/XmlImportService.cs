using Application.Interfaces;
using Domain.Entities;

namespace Infrastructure.Services
{
    /// <summary>
    /// Реализация сервиса импорта подразделений в XML формате.
    /// </summary>
    public class XmlImportService : IXmlImportService
    {
        public IEnumerable<Division> ImportDivisions(string xmlData)
        {
            throw new NotImplementedException();
        }
    }
}