using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Program.Model.modl;
using PROGRAM.DOMINE.domine;



namespace PPM.TEST1;

public class Test
{
    [Test]
    public void TestProjectData()
        {
            ProjectData projectData = new ProjectData();
            Project project = new Project("Test", "16/12/2022", "16/12/2023",1);
            projectData.Addproject(project);
            Assert.True(projectData.exist(1));
            
        }
    [Test]
    public void TestEmployeeManagement()
        {
            EmployeeManagement employeeManagement = new EmployeeManagement();
            Employee employee1 = new Employee(5,"Bhanu","Juluri","bhanu@gmail.com","9908941103","t66-te",1,"Manager");
            employeeManagement.AddEmp(employee1 );
            Assert.True(employeeManagement.exist(5));
            Assert.False(employeeManagement.exist(1));
          
            
        }
    [Test]
    public void TestRoleManagement()
        {
            RoleManagement roleManagement = new RoleManagement();
            Role role = new Role(1,"Bhanu");
            roleManagement.RoleAdd(role);
            Assert.True(roleManagement.exist(1));
          
        }
    

    [Test]
        public void TestAddproject()
        {
            List<Project> Prolifics =new List<Project>();
            Project project1 = new Project("Test", "16/12/2022", "16/12/2023",1);
            Prolifics.Add(project1);
        } 
    [Test]
         public void TestAddEmployee()
        {
             List<Employee> employeeList = new List<Employee>();
            Employee employee1 = new Employee(5,"Bhanu","Juluri","bhanu@gmail.com","9908941103","t66-te",1,"Manager");
            employeeList.Add(employee1);
        }
    [Test]
        public void TestRoleAdd()
        {
             List<Role> RoleList = new List<Role>();
             Role Role1 = new Role(1,"Bhanu");
             RoleList.Add(Role1); 
        }
}

