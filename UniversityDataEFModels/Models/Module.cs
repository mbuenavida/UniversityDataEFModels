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

        [Display(Name = "Título"), 
            Column("ModName", TypeName = "varchar(100)"),
            Required]
        public string? Name { get; set; }

        [Display(Name = "Código"), 
            Column("ModCode", TypeName = "varchar(25)"),
            Required]
        public string? Code { get; set; }

        [Display(Name = "Créditos"), 
            Required]
        public int Credits { get; set; }

        [Display(Name = "Duración"),
            Required]
        public DurationType Duration { get; set; }

        [Display(Name = "Obligatorio")]
        public bool Mandatory { get; set; }

        // ForeignKey
        [Display(Name = "ID Curso"), 
            Required]
        public int? CourseId { get; set; }


        // Propiedades de Navegación
        [Display(Name = "Curso")]
        public virtual Course? MyCourse { get; set; }
    }
}
