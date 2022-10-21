using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityDataEFModels.Models
{
    [Table("StudentRecords", Schema = "customSchema")]
    public class Student
    {
        public int Id { get; set; }

        [Column("FName", TypeName = "varchar(100)")]
        [Required]
        public string? FirstName { get; set; }

        [Column("LName", TypeName = "varchar(150)")]
        [Required]
        public string? LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string? Address { get; set; }

        [Required]
        public DateTime? CreatedOn { get; set; }
    }
}
