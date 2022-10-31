using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityDataEFModels.Models;
using UniversityDataEFModels.Services;

namespace UniversityDataEFModels.Controllers
{
    public class CoursesController : Controller
    {
        /// <summary>
        /// Se declara el repositorio de la clase
        /// </summary>
        private readonly IRepositoryCourse _repositoryCourse;
        /// <summary>
        /// Se inyecta el repositorio de la clase, en el constructor del controlador
        /// </summary>
        /// <param name="repositoryCourse"></param>
        public CoursesController(IRepositoryCourse repositoryCourse)
        {
            _repositoryCourse = repositoryCourse;
        }
        /// <summary>
        /// GET: CoursesController
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View("Index", _repositoryCourse.ListCourses());
        }
        /// <summary>
        /// GET: CoursesController/Details/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(int id)
        {
            return View(_repositoryCourse.GetCourse(id));
        }
        /// <summary>
        /// Método para crear nuevos registros 
        /// Muestra el formulario
        /// GET: CoursesController/Create
        /// </summary>
        /// <returns></returns>
        public ActionResult Create() // Muestra formulario
        {
            return View();
        }
        /// <summary>
        /// Método para crear nuevos registros 
        /// Ejecuta el formulario con los datos ingresados
        /// POST: CoursesController/Create
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, string name, string code, string section) //Ejecuta el formulario
        {
            try
            {
                _repositoryCourse.AddCourse(new Course() { Name = name, Code= code, Section= section });
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        /// <summary>
        /// Método para editar los datos de un registro
        /// Muestra el formulario
        /// GET: CoursesController/Edit/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Edit(int id)
        {
            var data = _repositoryCourse.GetCourse(id); 
            return View(data);
        }
        /// <summary>
        /// Método para editar los datos de un registro
        /// Ejecuta el formulario con los datos ingresados 
        /// POST: CoursesController/Edit/5
        /// </summary>
        /// <param name="id"></param>
        /// <param name="collection"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
              
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CoursesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CoursesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
