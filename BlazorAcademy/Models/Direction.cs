using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademy.Models
{
    public class Direction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public byte direction_id { get; set; }
        [Required]
        public string? direction_name { get; set; }
    }
}
