using System.ComponentModel.DataAnnotations;

namespace OrderService.Contract.Entities
{
    /// <summary>
    ///     Абстрактная модель сущности
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        ///     Уникальный идентификатор
        /// </summary>
        [Key]
        public long Id { get; set; }
    }
}