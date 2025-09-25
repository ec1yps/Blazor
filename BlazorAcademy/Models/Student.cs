using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace BlazorAcademy.Models
{
	public class Student
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int stud_id { get; set; }
		
		[Required, StringLength(50)]
		public string? last_name { get; set; }
		
		[Required, StringLength(50)]
		public string? first_name { get; set; }
		
		[StringLength(50)]
		public string? middle_name { get; set; }
		
		[Required, DataType(DataType.Date)]
		public DateTime? birth_date { get; set; }
		
		[StringLength(50)]
		public string? email { get; set; }

		[StringLength(16)]
		public string? phone { get; set; }

		public byte[]? photo { get; set; }

		public int group { get; set; }
	}
}
