using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarkBook.Data.Database.Model
{

    [Table("Schedule")]
    public partial class Schedule
    {
        [Key]
        public int id_schedule { get; set; }

        [Required]
        [StringLength(12)]
        public string weekday { get; set; }

        public int order { get; set; }

        public virtual Grade Grade { get; set; }

        public virtual Subject Subject { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}
