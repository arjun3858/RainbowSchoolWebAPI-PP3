using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RainbowSchoolWebAPI.Models
{
    [Table("Students")]
    public class Students
    {
        [Key]
        public int StudentId { get; set; }
        public string ?StudentName { get; set; }
    }
}
