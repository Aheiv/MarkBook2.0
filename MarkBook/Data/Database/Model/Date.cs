using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{
	[Table("Date")]
	public partial class Date
	{
		[Key]
		public int id_date { get; set; }

		[Required]
		[StringLength(20)]
		public string quarter {  get; set; }

		[Column(TypeName = "date")]

		public DateOnly date_start { get; set; }

		[Column(TypeName = "date")]
		public DateOnly date_end { get; set; }
	}
}
