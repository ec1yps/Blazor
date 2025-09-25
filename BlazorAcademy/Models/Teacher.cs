using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademy.Models
{
    public class Teacher
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short teacher_id { get; set; }

        [StringLength(50)]
        public string? last_name { get; set; }

        [StringLength(50)]
        public string? first_name { get; set; }

        [StringLength(50)]
        public string? middle_name { get; set; }

        [DataType(DataType.Date)]
        public DateOnly? birth_date { get; set; }

        [StringLength(50)]
        public string? email { get; set; }

        [StringLength(16)]
        public string? phone { get; set; }

        public byte[]? photo { get; set; }

        [DataType(DataType.Date)]
        public DateOnly work_since { get; set; }

        public decimal rate { get; set; }
    }
}
