namespace UniversityDataEFModels.Services
{
    using System.Collections.Generic;
    using UniversityDataEFModels.Models;

    public class EFRepositoryCourse :IRepositoryCourse
    {
        /// <summary>
        /// Interfaz para crear el Context y facilitar las migraciones.
        /// Inyección de la conexión con la DB.
        /// </summary>
        /// 
        private readonly DesignTimeUniversityContextFactory _contextFactory = new();

        /// <summary>
        /// Declaración del contecto actual
        /// </summary>
        /// 
         private readonly UniversityContext _context;

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// 
        public EFRepositoryCourse()
        {
            string[] args = new string[1];
            _context = _contextFactory.CreateDbContext(args);
        }
        /// <summary>
        /// Método para crear un nuevo curso     
        /// </summary>
        /// <param name="course"></param>
        public void AddCourse(Course course)
        {
            if (_context.Courses is not null)
            {
                _context.Courses.Add(course);
                _context.SaveChanges();
            }
        }

        public void EditCourse(Course course)
        {
            if (_context.Courses is not null)
            {
           
                //_context.Courses.Update(course);
                //_context.SaveChanges();
            }
        }
        /// <summary>
        /// Método que elimina un curso
        /// </summary>
        /// <param name="Id"></param>
        public void DeleteCourse(int Id)
        {
            if (_context.Courses is not null)
            {
                var course = GetCourse(Id);
                if (course is not null)
                {
                    _context.Courses.Remove(course);
                }
            }
        }
        /// <summary>
        /// Método que recoge los datos de un curso, por su id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Course? GetCourse(int Id)
        {
            if (_context.Courses is not null)
            {
                return _context.Courses.Find(Id);
            }
            return null;
        }
        /// <summary>
        /// Lista los datos de todos los cursos
        /// </summary>
        /// <returns></returns>
        public List<Course>? ListCourses()
        {
            if (_context.Courses is not null)
            {
                return _context.Courses.ToList();
            }
            return null;
        }
    }
}
