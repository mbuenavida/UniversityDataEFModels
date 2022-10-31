using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace UniversityDataEFModels.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            // Crear Context
            string[] args = { "" };
            using (UniversityContext context = new DesignTimeUniversityContextFactory().CreateDbContext(args)) {
                if (context.Courses.Any() || context.Modules.Any())
                {
                    return;   // DB has been seeded
                }
                context.Courses.AddRange(
                    new Course() 
                    { 
                        Name = "Sistemas e Ingeniería", 
                        Code = "123db", 
                        Section = "Informática" 
                    }, 
                    new Course()
                    {
                        Name = "Desarrollo Web",
                        Code = "693st",
                        Section = "Informática"
                    },
                    new Course()
                    {
                        Name = "Lenguaje de Marcas",
                        Code = "621npk",
                        Section = "Informática"
                    },
                    new Course()
                    {
                        Name = "Desktop Apps",
                        Code = "123db",
                        Section = "Informática"
                    }
                );
                context.SaveChanges();

                context.Modules.AddRange(
                    new Module()
                    {
                        Name = "Sistemas Operativos",
                        Code = "dsfg25r",
                        Credits = 55,
                        Duration = (DurationType)0,
                        Mandatory = true,
                        ////CourseId = 1
                    }, 
                    new Module()
                    {
                        Name = "Seguridad",
                        Code = "rss225r",
                        Credits = 40,
                        Duration = (DurationType)1,
                        Mandatory = true,
                        ////CourseId = 1
                    },
                    new Module()
                    {
                        Name = "Bases de Datos",
                        Code = "62s225r",
                        Credits = 25,
                        Duration = (DurationType)2,
                        Mandatory = false,
                        ////CourseId = 1
                    }, 
                    new Module()
                    {
                        Name = "Frameworks",
                        Code = "dsfg25r",
                        Credits = 55,
                        Duration = (DurationType)0,
                        Mandatory = true,
                        //CourseId = 2
                    },
                    new Module()
                    {
                        Name = "Web Apps",
                        Code = "rss225r",
                        Credits = 40,
                        Duration = (DurationType)1,
                        Mandatory = true,
                        //CourseId = 2
                    },
                    new Module()
                    {
                        Name = "Web API",
                        Code = "62s225r",
                        Credits = 25,
                        Duration = (DurationType)2,
                        Mandatory = false,
                        //CourseId = 2
                    },
                    new Module()
                    {
                        Name = "Java",
                        Code = "dsfg25r",
                        Credits = 55,
                        Duration = (DurationType)0,
                        Mandatory = true,
                        //CourseId = 3
                    },
                    new Module()
                    {
                        Name = "Php",
                        Code = "rwef25r",
                        Credits = 40,
                        Duration = (DurationType)1,
                        Mandatory = true,
                        //CourseId = 3
                    },
                    new Module()
                    {
                        Name = "C#",
                        Code = "62s225r",
                        Credits = 25,
                        Duration = (DurationType)2,
                        Mandatory = false,
                        //CourseId = 3
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
