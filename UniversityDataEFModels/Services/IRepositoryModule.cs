namespace UniversityDataEFModels.Services
{
    using UniversityDataEFModels.Models;

    public interface IRepositoryModule
    {
        Module? GetModule(int Id);
        void DeleteModeule(int Id);
        void AddModule(Module modulo);
        List<Module>? ListModules();
    }
}
