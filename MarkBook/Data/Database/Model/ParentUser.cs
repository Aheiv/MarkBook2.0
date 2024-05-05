using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{
	[Table("parent_user")]
	public partial class ParentUser
	{
		[Key]
		public int id { get; set; }

		[Required]
		[StringLength(255)]
		public string username { get; set; }
		[Required]
		public string password { get; set; }
		[Required]
		public virtual Parent Parent { get; set; }
	}
}