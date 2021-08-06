using System.ComponentModel.DataAnnotations;

namespace Catalog.DTOs
{
    public record UpdateItemDTO
    {
        [Required]//Делает это свойстов обязательным для заполнения
        public string Name { get; init; }
        [Required]//Делает это свойстов обязательным для заполнения
        [Range(1, 1000)]//Указывает диапозон допустимых значений
        public decimal Price { get; init; }
    }
}