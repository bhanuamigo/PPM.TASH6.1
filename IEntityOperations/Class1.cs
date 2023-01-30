
using Program.Model.modl;
namespace IEntityOperations
{
interface IEntityOperationsProjects
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
interface IEntityOperationsEmployees
{
    void AddEmployee(Employee employee);
    void displayEmployee(Employee employee);
    void ViewAllEmployees();
    void ShowEmployee(int employeeid);
    void DeleteEmployee(int employeeId, Employee employee);
}
interface IEntityOperationRole
{
    void RoleAdd(Role role);
    void DisplayRole();
    void ListRoleById(int roleId);
    void DeleteRole (int roleId);
}

}