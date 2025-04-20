using Domain.Entities;

namespace Application.Dto
{
    public class DivisionNode
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Guid? ParentId { get; set; }
        public int Order { get; set; }
        public List<Division> Children { get; set; } = new List<Division>();
    }
}