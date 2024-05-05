using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{
	[Table("student_user")]
	public partial class StudentUser
	{
		[Key]
		public int id { get; set; }

		[Required]
		[StringLength(255)]
		public string username { get; set; }
		[Required]
		public string password { get; set; }

		[Column("student_id")]
		public int StudentId { get; set; }
		[Required]
		public virtual Student Student { get; set; }
	}
}
