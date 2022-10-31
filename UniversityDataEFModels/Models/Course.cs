using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UniversityDataEFModels.Models
{
    [Table("CourseRecords", Schema = "customSchema")]
    public class Course
    {
        public int Id { get; set; }

        [Display(Name = "Título"),
            Column("CourName",TypeName = "varchar(100)"),
            Required] 
        public string? Name { get; set; }

        [Display(Name = "Código"), 
            Column("CourCode", TypeName = "varchar(25)"),
            Required]
        public string? Code { get; set; }

        [Display(Name = "Sección"),
           Required]
        public string? Section { get; set; }
        
        
        // Propiedades de Navegación
        public virtual List<Module>? Modules { get; set; }
    }
}
