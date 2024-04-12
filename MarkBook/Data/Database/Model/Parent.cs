using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MarkBook.Data.Database.Model
{

    [Table("Parent")]
    public partial class Parent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parent()
        {
            Student_Parent = new HashSet<Student_Parent>();
        }

        [Key]
        public int id_parent { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Фамилия не может быть более 30 символов")]
        public string surname { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Имя не может быть более 30 символов")]
        public string name { get; set; }

        [StringLength(30, ErrorMessage = "Отчество не может быть более 30 символов")]
        public string patronymic { get; set; }

        [Required]
        [StringLength(3, ErrorMessage = "Пол не может быть более 3 символов")]
        public string gender { get; set; }

        public string? workplace {  get; set; }
        public string? profession {  get; set; }


        [Required]
        [StringLength(12, ErrorMessage = "Номер телефона не может быть более 12 символов")]
        public string phonenumber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Parent> Student_Parent { get; set; }
    }
}
