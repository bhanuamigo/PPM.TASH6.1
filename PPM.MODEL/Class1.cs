
namespace Program.Model.modl
{




public class Project: IComparable<Project>
{
    public List<Employee> AddingEmployeelist = new List<Employee>();
    public int id { get; set; }
    public string projectName { get; set; }
    public string startDate { get; set; }
    public string endDate { get; set; }
    


    public Project(string ProjectName, string StartDate, string EndDate, int Id)
    {
        this.id = Id;
        this.projectName = ProjectName;
        this.startDate = StartDate;
        this.endDate = EndDate;
        
    }
    public Project()
    {

    }
     public Project (int empid)
        {
            this.id = empid;
        }
        public int CompareTo(Project other)
        {
            return this.id.CompareTo(other.id);
        }

        /*public int CompareTo(Project other)
        {
            return this.id.CompareTo(other.id);
        }*/
}
public class Employee: IComparable<Employee>
{
    public int employeeId { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public string mobile { get; set; }
    public string address { get; set; }
    public int roleId { get; set; }
    public string roleName { get; set; }


    public Employee(int EmployeeId, string FirstName, string LastName, string Email, string Mobile, string Address, int RoleID, string Rolename)
    {
        this.employeeId = EmployeeId;
        this. firstName = FirstName;
        this.lastName = LastName;
        this.email = Email;
        this.mobile = Mobile;
         this. address = Address;
        this.roleId = RoleID;
        this.roleName = Rolename;
    }

    public Employee()
    {

    }
    public int CompareTo(Employee other)
    {
        return this.roleId.CompareTo(other.roleId);
    }

    
}
public class Role: IComparable<Role>
{
    public string roleName { get; set; }
    public int roleId { get; set; }

    public Role(int RoleId, string RoleName)
    {
       this.roleName = roleName;
        this.roleId = RoleId;
    }

    public int CompareTo(Role other)
        {
            return this.roleId.CompareTo(other.roleId);
        }
}
}

