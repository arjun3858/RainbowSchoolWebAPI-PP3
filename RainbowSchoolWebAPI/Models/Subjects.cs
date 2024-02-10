using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RainbowSchoolWebAPI.Models
{
    [Table("Subjects")]
    public class Subjects
    {
        [Key]
        public int SubjectId { get; set; }
        public string ?SubjectName { get; set; }
    }
}
