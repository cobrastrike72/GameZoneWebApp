using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Madrid.GameZone.Models
{
    public class Game : BaseEntity
    {
        public string Description { get; set; } = string.Empty;
        [MaxLength(500)]
        public string Cover { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;// navigation property
        public ICollection<GameDevice> Devices { get; set;} = new List<GameDevice>();
    }
}
