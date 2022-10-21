namespace UniversityDataEFModels.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public enum DurationType
    {
        Anual = 0,
        C1 = 1,
        C2 = 2
    }

    [Table("ModulesRecords", Schema = "customSchema")]
    public class Module
    {
        public int Id { get; set; }

        [Column("ModName", TypeName = "varchar(100)")]
        [Required]
        public string? Name { get; set; }

        [Column("ModCode", TypeName = "varchar(25)")]
        [Required]
        public string? Code { get; set; }

        [Required]
        public int Credits { get; set; }

        public DurationType Duration { get; set; }

        public bool Mandatory { get; set; }

        // ForeignKey
        [Required]
        public int CourseId { get; set; }


        // Propiedades de Navegación
        public virtual Course? MyCourse { get; set; }
    }
}
