using Domain.Entities;

namespace Application.Interfaces
{
    public interface IXmlExportService
    {
        string ExportDivisions(IEnumerable<Division> divisions);
    }
}