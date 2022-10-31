using Microsoft.EntityFrameworkCore.Metadata.Internal;
using UniversityDataEFModels.Models;

namespace UniversityDataEFModels.Services
{
    public class EFRepositoryModule : IRepositoryModule
    {
        // Generador de contexts.
        private readonly DesignTimeUniversityContextFactory _contextFactory = new();

        // Instancia del Context que se va a utilizar
        private readonly UniversityContext _context;

        // Constructor e Inyección del Context, ya generado.
        public EFRepositoryModule()
        {
            string[] args = new string[1];
            _context = _contextFactory.CreateDbContext(args);
        }

        public List<Module>? ListModules()
        {
            if (_context.Modules is not null)
            {
                return _context.Modules.ToList();
            }
            return null;
        }

        public Module? GetModule(int Id)
        {
            if (_context.Modules is not null)
            {
                return _context.Modules.Find(Id);
            }
            return null;
        }

        public void AddModule(Module modulo)
        {
            if (_context.Modules is not null)
            {
                _context.Modules.Add(modulo);
                _context.SaveChanges();
            }
        }

        public void DeleteModeule(int Id)
        {
            if (_context.Modules is not null)
            {
                var course = GetModule(Id);
                if (course is not null)
                {
                    _context.Modules.Remove(course);
                }
            }
        }

       

        
    }
}
