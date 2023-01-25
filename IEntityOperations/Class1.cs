
using Program.Model.modl;
namespace IEntityOperations
{
public interface IEntityOperationsProjects
{
        void Addproject(Project project);
         void viewProject(Project project);
         void ViewAllProjects();

         List<Employee> SearchingForEmployee(int readingProjectId);
         
         void DisplayEmployeesInProjectById(int readingProjectId);
         void AddingEmployeeToPrEoject (int ProjectId, Employee employeeName);
         void DeleteProject(int ProjectId, Project project);
         void EmployeeFromProject(int ProjectId, Employee employeeName);
         void ShowProject(int eid);
         void SearchProjectByName(string search);
}



}