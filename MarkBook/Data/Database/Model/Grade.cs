using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{
	[Table("grade")]
	public partial class Grade
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Grade()
		{
			Students = new HashSet<Student>();
		}

		[Key]
		[Column("id")]
		public int Id { get; set; }

		[Column("name")]
		public int Name { get; set; }

		[Column("subname")]
		[StringLength(1)]
		public string Subname { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<Student> Students { get; set; }
		public virtual ICollection<TeacherSubjectGrade> TeacherSubjectGrades { get; set;}
	}
}
