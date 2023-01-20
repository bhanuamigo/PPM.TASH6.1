
using Program.Model.modl;
namespace PROGRAM.DOMINE.domine
{
public class ProjectData
{
    public List<Project> Prolifics = new List<Project>();

    //Method to add project
    public void Addproject(Project project)
    {
        Prolifics.Add(project);
    }
    public void viewProject(Project project)
    {
        Console.WriteLine(" Name of the  Project - " + project.projectName + "\n Project Id - " + project.id + "\n Start date of Project - " + project.startDate + "\n End date of Project - " + project.endDate);
        Console.WriteLine("");
    }
     public void display()
    {
        for (int j = 0; j < Prolifics.Count; j++)
        {
                if(Prolifics[j].AddingEmployeelist.Count == 0)
                {
                    Console.WriteLine("No employee in  project");
                }
                else
                {
                    Console.WriteLine("Project Name - " + Prolifics[j].projectName);
                    Console.WriteLine("Name of the employees in the project :");
                for (int i = 0; i < Prolifics[j].AddingEmployeelist.Count; i++)
                {
                    Console.WriteLine(Prolifics[j].AddingEmployeelist[i].firstName);
                }
                }
        }
    }
    public void ViewAllProjects()
    {
        if (Prolifics.Count == 0)
            {
                Console.WriteLine("The List is Empty !!!");
            }
            else
            {
            foreach (var p in Prolifics)
             {
            viewProject(p);
            }
            }
    }
    public void EmployeeToProject(int ProjectId,Employee employeeName){
        for(int i=0; i<Prolifics.Count;i++){
            if(Prolifics[i].id==ProjectId){
                Prolifics[i].AddingEmployeelist.Add(employeeName);
            }
        }
    }

     public void EmployeeFromProject(int ProjectId,Employee employeeName){
        for(int i=0; i<Prolifics.Count;i++){
            if(Prolifics[i].id==ProjectId){
                Prolifics[i].AddingEmployeelist.Remove(employeeName);
            }
        }
    }


    public Boolean exist(int ProjectId){
        for(int i=0; i<Prolifics.Count;i++)
        {
            if(ProjectId== Prolifics[i].id)
            {
                return true;
            }
        }
        return false;
    }

   

    //Method to view all projects
    public void ShowProject(int eid)
    {
        foreach (Project p in Prolifics)
        {

            if (p.id == eid)
            {
                Console.WriteLine(" Name of the project - " + p.projectName + "\n Project Id - " + p.id + "\n Start  date of project - " + p.startDate + "\n deadline  of the Project - " + p.endDate);
            }
            else
            {
                Console.WriteLine("Invalid ID re-enter valid ID");
            }
        }
    }

    public void SearchProject(string search)
    {
        var match = Prolifics.Where(c => c.projectName.Contains(search));
        foreach (var e in match)
        {
            Console.WriteLine("");
            Console.WriteLine(" Name of the project - " + e.projectName + "\n Project Id - " + e.id + "\n Start date of project - " + e.startDate + "\n Deadline  of project - " + e.endDate);
        }
    }

    public void Display()
    {
        
            for (int j = 0; j < Prolifics.Count; j++)
            {
                if(Prolifics[j].AddingEmployeelist.Count == 0){
                    Console.WriteLine("No employee in the project");
                }
                else{
                    Console.WriteLine("Project Name - " + Prolifics[j].projectName);
                    Console.WriteLine("Names of the employees in the project :");
                for (int i = 0; i < Prolifics[j].AddingEmployeelist.Count; i++)
                {
                    Console.WriteLine(Prolifics[j].AddingEmployeelist[i].firstName);
                }
            }}
    }
}
public class EmployeeManagement
{
    public List<Employee> employeeList = new List<Employee>();

    //Method to add new employee
    public void AddEmp(Employee emp)
    {
        employeeList.Add(emp);
    }


    public void displayEmployee(Employee emp)
    {
        Console.WriteLine(" Employee Id - " + emp.employeeId + "\n Employee first name - " + emp.firstName + "\n Employee last name - " + emp.lastName + "\n Employee email id - " + emp.email + "\n Employee mobile number - " + emp.mobile + "\n Employee address - " + emp.address + "\n Role Id - " + emp.roleId + "\n Role Name - " + emp.roleName);
        Console.WriteLine("");
    }

    //Method to view all employees
    public void ShowEmployees()
    {
        foreach (var j in employeeList)
        {
            displayEmployee(j);
        }
    }

    public void ShowEmployee(int eid)
    {
        foreach (Employee j in employeeList)
        {

            if (j.employeeId == eid)
            {
                Console.WriteLine(" Name of the Employee - " + j.firstName + " " + j.lastName + "\n Employee Id - " + j.employeeId);
            }
            else
            {
                Console.WriteLine("Invaild ID re-entre the vaild ID");
            }
        }
    }

    public Boolean exist(int eid){
        for(int i=0; i<employeeList.Count;i++){
            if(eid== employeeList[i].employeeId){
                return true;
            }
        }
        return false;
    }

    public Employee eDetails(int eid){
        Employee emp = new Employee();
        for(int i=0;i<employeeList.Count;i++){
            if(eid==employeeList[i].employeeId){
               emp=employeeList[i];
                return emp;
            }
        }
        return emp;
    }
}
}

public class RoleManagement
{


    public List<Role> RoleList = new List<Role>();



    //Method  to add roles
    public void RoleAdd(Role role)
    {
        RoleList.Add(role);
    }

    //Method to view all roles
    public void DisplayRole()
    {
        foreach (var e in RoleList)
        {
            Console.WriteLine(" Name of the Role - " + e.roleName + "\n Role Id - " + e.roleId);
            Console.WriteLine();
        }
    }
     public Boolean exist(int roleId)
        {
            for (int i = 0; i < RoleList.Count; i++)
            {
                if (RoleList[i].roleId == roleId)
                {
                    return true;
                }
            }
            return false;
        }
        
 }


