using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{
	[Table("teacher_user")]
	public partial class TeacherUser
	{
		[Key]
		public int id { get; set; }

		[Required]
		[StringLength(255)]
		public string username {  get; set; }
		[Required]
		public string password { get; set; }

		[Column("teacher_id")]
		public int TeacherId;
		[Required]
		public virtual Teacher Teacher { get; set; }
	}
}
