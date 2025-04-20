using Application.Interfaces;
using Domain.Entities;

namespace Infrastructure.Services
{
    /// <summary>
    /// Реализация сервиса экспорта подразделений в XML формате.
    /// </summary>
    public class XmlExportService : IXmlExportService
    {
        public string ExportDivisions(IEnumerable<Division> divisions)
        {
            throw new NotImplementedException();
        }
    }
}
