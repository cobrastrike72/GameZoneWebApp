using System.ComponentModel.DataAnnotations;

namespace Madrid.GameZone.Models
{
    public class BaseEntity
    {
        public int Id { get; set; } // auto-incremented and requiered
        [MaxLength(250)]
        public string Name { get; set; } = string.Empty;
    }
}
