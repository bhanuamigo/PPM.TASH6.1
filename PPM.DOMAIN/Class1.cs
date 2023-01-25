
using Program.Model.modl;
namespace PROGRAM.DOMINE.domine
{
public class ProjectData 
{
    public List<Project> Prolifics = new List<Project>();
    EmployeeManagement obj1 = new EmployeeManagement();

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
   
      public Boolean IfNoEmployeesInProject(int ProjectId)
        {
            for (int i=0; i<Prolifics.Count; i++)
            {
                if(Prolifics[i].id == ProjectId && Prolifics[i].AddingEmployeelist.Count==0)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Employee> SearchingForEmployee (int readingProjectId)
        {
            foreach(Project i in Prolifics)
            {
                i.AddingEmployeelist.Sort();
                if(!IfNoEmployeesInProject(readingProjectId) && i.id == readingProjectId)
                {
                    return i.AddingEmployeelist;
                }
            }
            return null;
        }
        public void Display()
        {
            for (int i=0; i<Prolifics.Count; i++)
            {
                Console.WriteLine("Project Name - " + Prolifics[i].projectName);
                Console.WriteLine(" ****************************************** ");
                Console.WriteLine("Below are the Details of Employees in this Project");
                for(int j=0; j<Prolifics[i].AddingEmployeelist.Count; j++)
                {
                    Console.WriteLine(" ------------------------------------------- ");
                    Console.WriteLine(Prolifics[i].AddingEmployeelist[j].firstName+ " [" +Prolifics[i].AddingEmployeelist[j].roleName + "]");
                    Console.WriteLine(" ------------------------------------------- ");
                }
            }
        }
        
    public void EmployeeToProject(int ProjectId,Employee employeeName)
    {
    if(obj1.exist(ProjectId))
    {
        for(int i=0; i<Prolifics.Count;i++)
        {
            if(Prolifics[i].id==ProjectId)
            {
                Prolifics[i].AddingEmployeelist.Add(employeeName);
            }
        }
    }
    else
    {
        Console.WriteLine("With this ID the Employee already exists in this Project");
        Console.WriteLine("Enter any key to get Main Menu");
        Console.ReadLine();
    }
    }
     public Project SearchingProject(List<Project> Prolifics, int first , int last, int ProjectId)
        {
            if(first <= last)
            {
                int midpoint = (first+last) / 2;
                if (Prolifics[midpoint].id == ProjectId)
                {
                    return Prolifics[midpoint];
                }
                else if (Prolifics[midpoint].id > ProjectId)
                {
                    return SearchingProject(Prolifics, first, midpoint-1, ProjectId);
                }
                else if (Prolifics[midpoint].id < ProjectId);
                {
                    return SearchingProject(Prolifics, midpoint+1, last, ProjectId);
                }
            }
            return null;
        }
     public void AddingEmployeeToProject(int ProjectId, Employee ename)
        {
            foreach(Project i in Prolifics)
            {
                if(i.id == ProjectId)
                {
                    i.AddingEmployeelist.Add(ename);
                }
            }
        }

        public void DeleteProject(int ProjectId, Project project)
        {
            for (int i=0; i<Prolifics.Count; i++)
            {
                if(Prolifics[i].id == ProjectId)
                {
                    Prolifics.Remove(project);
                }
            }
        }
public void EmployeeFromProject(int ProjectId,Employee employeeName)
{
    for (int i=0; i<Prolifics.Count; i++)
    {

        for(int j=0; j<Prolifics[i].AddingEmployeelist.Count;j++)
        {
            if(Prolifics[i].id==ProjectId)
            {
                if(Prolifics[i].AddingEmployeelist.Count !=0)
                {
                Prolifics[i].AddingEmployeelist.Remove(employeeName);
                }
                else
                {
                    Console.WriteLine("No Employee Found in the Project to Delete");
                } 
            }
        }
    }
}
public void DeleteEmployeeFromProject(int eid, Employee employeeName)
        {
            for(int i=0; i<Prolifics.Count; i++)
            {
                for(int j=0; j<Prolifics[i].AddingEmployeelist.Count; j++)
                {
                    if(Prolifics[i].AddingEmployeelist[j].employeeId == eid)
                    {
                        Prolifics[i].AddingEmployeelist.Remove(employeeName);
                    }
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
/*public Boolean IfExistsInEmployee(int employeeid, int ProjectId)
        {
            for (int i=0; i<Prolifics.Count; i++)
            {
                for (int j=0; j<Prolifics[i].AddingEmployeelist.Count; j++)
                {
                    if(employeeid == Prolifics[i].AddingEmployeelist[j].employeeId)
                    {
                        return true;
                    }
                }
            }
            return false;
        }*/

        public Boolean IfExistsInEmployee(int employeeid, int ProjectId)
        {
            for (int i=0; i<Prolifics.Count; i++)
            {
                if(ProjectId == Prolifics[i].id)
                {
                    for (int j=0; j<Prolifics[i].AddingEmployeelist.Count; j++)
                    {
                        if(employeeid == Prolifics[i].AddingEmployeelist[j].employeeId)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
     public void ShowProject(int eid)
        {
            Prolifics.Sort();
            int first = 0;
            int last = Prolifics.Count -1;
            Project project = SearchingProject(Prolifics, first, last, eid);
            if(project != null)
            {
                viewProject(project);
            }
            else
            {
                Console.WriteLine("No Project Found with this ID");
            }
        }


    public void SearchProjectByName(string search)
    {
        var match = Prolifics.Where(c => c.projectName.Contains(search));
        foreach (var e in match)
        {
            Console.WriteLine("");
            Console.WriteLine(" Name of the project - " + e.projectName + "\n Project Id - " + e.id + "\n Start date of project - " + e.startDate + "\n Deadline  of project - " + e.endDate);
        }
    }

   /* public void Display()
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
    }*/
}
public class EmployeeManagement
{
    public List<Employee> ProlificsemployeeList = new List<Employee>();

    //Method to add new employee
    public void AddEmployee(Employee employee)
    {
        ProlificsemployeeList.Add(employee);
    }


    public void displayEmployee(Employee employee)
    {
        Console.WriteLine(" Employee Id - " + employee.employeeId + "\n Employee first name - " + employee.firstName + "\n Employee last name - " + employee.lastName + "\n Employee email id - " + employee.email + "\n Employee mobile number - " + employee.mobile + "\n Employee address - " + employee.address + "\n Role Id - " + employee.roleId + "\n Role Name - " + employee.roleName);
        Console.WriteLine("");

    }
    public Employee EmployeeDetails(int employeeid)
        {
            Employee employee = new Employee();
            for(int i=0; i<ProlificsemployeeList.Count; i++)
            {
                if(employeeid == ProlificsemployeeList[i].employeeId)
                {
                    employee = ProlificsemployeeList[i];
                    return employee;
                }
            }
            return employee;
        }

    //Method to view all employees
    public void ViewAllEmployees()
    {
        if(ProlificsemployeeList.Count == 0)
        {
            Console.WriteLine("No Employees Available");
        }
        else
        {
            foreach (var j in ProlificsemployeeList)
            {
            displayEmployee(j);
            }
        }
    }
 public Employee SerachingEmployeeInEmployeeList(List<Employee>list, int first, int last, int j)
        {
            if (first <= last)
            {
                int midpoint = (first+last) / 2;
                if (list[midpoint].employeeId == j)
                {
                    return list[midpoint];
                }
                else if (list[midpoint].employeeId >j)
                {
                    return SerachingEmployeeInEmployeeList(list, first, midpoint-1, j);
                }
                else if (list[midpoint].employeeId < j)
                {
                    return SerachingEmployeeInEmployeeList(list, midpoint+1 ,last, j);
                }
            }
            return null;
        }
    public void ShowEmployee(int employeeid)
    {
        ProlificsemployeeList.Sort();
        int first = 0;
        int last = ProlificsemployeeList.Count -1;
        Employee j = SerachingEmployeeInEmployeeList(ProlificsemployeeList, first, last, employeeid);
    
            if (j ! = null)
            {
                Console.WriteLine(" Name of the Employee - " + j.firstName + " " + j.lastName + "\n Employee Id - " + j.employeeId);
            }
            else
            {
                Console.WriteLine("Invaild ID re-entre the vaild ID");
            }
        
    }

    public Boolean exist(int employeeid){
        for(int i=0; i<ProlificsemployeeList.Count;i++)
        {
            if(employeeid== ProlificsemployeeList[i].employeeId)
            {
                return true;
            }
        }
        return false;
    }
    public void DeleteEmployee(int employeeId, Employee employee)
        {
            for (int i=0; i<ProlificsemployeeList.Count; i++)
            {
                if (ProlificsemployeeList[i].employeeId == employeeId)
                {
                    ProlificsemployeeList.Remove(employee);
                }
            }
        }

        public Boolean IfExistsByRole(int roleId)
        {
            for (int i=0; i<ProlificsemployeeList.Count; i++)
            {
                if (ProlificsemployeeList[i].roleId == roleId)
                {
                    return true;
                }
            }
            return false;
        }
    }

/*public Employee eDetails(int eid)
   {
        Employee emp = new Employee();
        for(int i=0;i<ProlificsemployeeList.Count;i++)
        {
            if(eid==ProlificsemployeeList[i].employeeId)
            {
               emp=ProlificsemployeeList[i];
                return emp;
            }
        }
        return emp;
    }*/
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


