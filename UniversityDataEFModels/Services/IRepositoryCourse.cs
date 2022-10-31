using UniversityDataEFModels.Models;

namespace UniversityDataEFModels.Services
{
    public interface IRepositoryCourse
    {
        Course? GetCourse(int Id);
        void DeleteCourse(int Id);
        void AddCourse(Course course);
        void EditCourse(Course course);

        List<Course>? ListCourses();
    }
}
