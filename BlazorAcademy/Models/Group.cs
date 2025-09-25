using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademy.Models
{
	public class Group
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int group_id { get; set; }
		[Required]
		public string? group_name { get; set; }
		[Required]
		public byte direction { get; set; }
		[Required]
		public byte weekdays { get; set; }
		[Required]
		[DataType(DataType.Time)]
		public TimeOnly start_time { get; set; }
	}
}
