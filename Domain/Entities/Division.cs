using Domain.Enum;

namespace Domain.Entities
{
    /// <summary>
    /// Доменная сущность, представляющая подразделение в организационной иерархии.
    /// </summary>
    public class Division
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Guid? ParentId { get; set; }
        /// <summary>
        /// Это свойство определяет тип подразделения.
        /// Компания, департамент или отдел.
        /// </summary>
        public DivisionLevel Order { get; set; }
        
        /// <summary>
        /// Поле для контроля одновременного доступа через EF Core.
        /// </summary>
        public byte[]? RowVersion { get; set; }
        
        // Для работы внутри приложения.
        public List<Division> Children { get; set; } = new List<Division>();

        // Ивенты записи, доп. логика.
    }
}