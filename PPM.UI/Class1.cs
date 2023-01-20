
using Program.Model.modl;
using PROGRAM.DOMINE.domine;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace PROGRAM.UI.ui
{


 public class UI
{
   public void Viewing()
   {

        ProjectData obj = new ProjectData();
        Employee employee = new Employee();
        Project project = new Project();
        EmployeeManagement obj1 = new EmployeeManagement();
        RoleManagement obj2 = new RoleManagement();
        obj2.RoleList.Add(new Role(1,"Manager"));
        obj2.RoleList.Add(new Role(2,"Asst.Manger"));
        obj2.RoleList.Add(new Role(3,"Software Engineer" ));
        obj2.RoleList.Add(new Role(4,"Associate Software Engineer" ));
        obj2.RoleList.Add(new Role(5,"Trainee Software Engineer" ));


        Console.WriteLine("");
        Boolean error = false;


        Regex phonenumber = new Regex(@"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]{2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)");
        Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Regex date = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
        View:
            Console.WriteLine("");
            Console.WriteLine("                                      *** | PROLIFICS PROJECT MANAGEMENT    | ***                                    ");
            Console.WriteLine("");
            Console.WriteLine("\n \n  HELLO PROLIFIAN ");
            Console.WriteLine("");
            Console.Write("\n \n  Select  Operation ");
            Console.WriteLine("");
            Console.Write("                                           Enter \"1\" : Project Module");
            Console.WriteLine("");
            Console.Write("                                           Enter \"2\" : Employee Module");
            Console.WriteLine("");
            Console.Write("                                           Enter \"3\" : Role Module");
            Console.WriteLine("");
            Console.WriteLine("                                       Enter \"x\" : exit application");
            Console.WriteLine("");
            Console.Write("\n \n Please  Enter Selected Operation ");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            var read = Console.ReadLine();
            while (true)
            {
            repeat:
                switch (read)
                {
                    case "1":
                        while (true)
                        {
                        projectModule:
                            Console.WriteLine("");
                            Console.WriteLine("                                     ****| Welcome to Project Module   |***                                    ");
                            Console.WriteLine("");
                            Console.Write("\n \n  Select  Operation ");
                            Console.Write("                                           Enter \"1\" : Add Project");
                            Console.WriteLine("");
                            Console.Write("                                           Enter \"2\" : View  all Projects");
                            Console.WriteLine("");
                            Console.Write("                                           Enter \"3\" : View  Project by ID");
                            Console.WriteLine("");
                            Console.Write("                                            Enter \"4\" : View Project by Name");
                            Console.WriteLine("");
                            Console.WriteLine("                                       Enter \"5\" : Add Employee to Project");
                            Console.WriteLine("");
                            Console.WriteLine("                                       Enter \"6\"  : Remove Employee from Project");
                            Console.WriteLine("");
                            Console.WriteLine("                                       Enter \"7\"  : View Projects with Employees");
                            Console.WriteLine("");
                            Console.WriteLine("                                      Enter \"8\"  : Delete  Project");
                            Console.WriteLine("");
                            Console.WriteLine("                                       Enter \"x\"  : Main Menu");
                            Console.WriteLine("");
                            Console.Write("\n \n Please  Enter Selected Operation ");
                            Console.WriteLine("");
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------");
                            var projectselect = Console.ReadLine();
         while (true)
        {
            switch (projectselect)
            {
                case "1":
                    Console.WriteLine("");
                    do
                    {
                    try
                     { 
                        ProjectId:
                        error = false;
                        Console.WriteLine("Enter Project Id");
                        int Id = Convert.ToInt32(Console.ReadLine());
                        for(int i = 0; i< obj.Prolifics.Count;i++)
                        {
                        if(obj.Prolifics[i].id == Id)
                        {
                            Console.WriteLine("The Id already Exists \t");
                            Console.WriteLine("\n Enter any key to try again");
                            Console.WriteLine("\n Press x to get  Main Menu");

                            var tryId = Console.ReadLine();
                            if(tryId == "x")
                            {
                               goto projectModule;
                            }
                            else
                            {
                                goto ProjectId;
                            }
                            }
                        }
                        
                        Console.WriteLine("Enter Project Name");
                        string? name = Console.ReadLine();

                        startDate:
                        Console.WriteLine("Enter Project Start Date of Project DD/MM/YYYY formate");
                        string?  start = Console.ReadLine();
                        if(!date.IsMatch(start))
                                {
                                    Console.WriteLine("Invalid Date Format");
                                    Console.WriteLine("Enter any key to Try Again");
                                    Console.WriteLine("Enter  \"x\" to Exit to Main Menu");
                                    var sDateread=Console.ReadLine();

                                    if(sDateread == "x")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        goto startDate;
                                    }
                                }
                                
                        EndDate:
                                Console.WriteLine("Enter End Date of Project in DD/MM/YYYY format");
                                string? end = Console.ReadLine();
                                if (!date.IsMatch(end))
                                {
                                    Console.WriteLine("Invalid Date Format");
                                    Console.WriteLine("Enter any key to Try Again");
                                    Console.WriteLine("Enter \"x\" to Exit to  Main Menu");
                                    
                                    var eDateread = Console.ReadLine();
                                    if (eDateread == "x")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        goto EndDate;
                                    }

                                }
                        Project project1 = new Project(name, start, end, Id);
                        project = project1;
                        obj.Addproject(project);
                        Console.WriteLine(" \n Project Added Successfully! \t ");
                        Console.WriteLine(" \n Enter any key to get back to Main Menu \t ");
                        Console.ReadLine();
                        goto projectModule;
                        
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\nError : only use Numbers for ID");
                        Console.WriteLine("Enter any key to Try Again");
                        Console.WriteLine("Enter  \"x\" to get Main Menu");
                            
                                read= Console.ReadLine();
                                if(read == "x")
                                {
                                    break;
                                }
                                error = true;
                    }
                        
                        catch (Exception)
                            {
                                Console.WriteLine("\nError : Only use Numbers for ID");
                                Console.WriteLine("Enter any key to Try Again");
                                Console.WriteLine("Enter  \"x\" to get Main Menu");
                            
                                
                                read = Console.ReadLine();
                                if(read == "x")
                                {
                                    
                                    break;
                                }
                                error = true;
                            }
                    
                }
            
                while(error);
                    break;
                case "2":
                    obj.ViewAllProjects();
                     Console.WriteLine("Enter any key to get back  to main menu");
                    Console.ReadLine();
                    break;
                case "3":
                    try
                    {
                        Console.WriteLine("Search via project id");
                        Console.WriteLine("Enter  id of project");
                        int eid = Convert.ToInt32(Console.ReadLine());
                        obj.ShowProject(eid);
                        Console.WriteLine();
                        Console.WriteLine("Enter any key to get back to main menu");
                        Console.ReadLine();
                    }
                    catch (Exception ) 
                    {
                         Console.WriteLine("Id should be in numbers formate"); 
                    }
                    break;
                case "4":
                        Console.WriteLine("Type to search for project");
                        read = Console.ReadLine();
                        obj.SearchProject(read);
                        Console.WriteLine("Enter any key to get to main menu");
                        Console.ReadLine();
                        break;
                case "5":
                        Console.WriteLine("");
                        Console.WriteLine("Available projects");
                        obj.ViewAllProjects();
                        Console.WriteLine();
                        Console.WriteLine(" Available employees");
                        obj1.ShowEmployees();
                        Console.WriteLine("Enter  Project ID ");
                        int PROJId = Convert.ToInt32(Console.ReadLine());
                        if(obj.exist(PROJId))
                        {
                         Console.WriteLine("Enter the  employee ID ");
                        int EmpId = Convert.ToInt32(Console.ReadLine());
                        if( obj1.exist(EmpId)){
                            employee = obj1.eDetails(EmpId);
                            obj.EmployeeToProject(PROJId,employee);
                            Console.WriteLine(" Project Added Successfully");
                             Console.WriteLine("Enter any key to get to main menu");
                            Console.ReadLine();
                        }
                        else{
                             Console.WriteLine("Employee does not exist");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Project does not exist");
                    }
                    var Read = Console.ReadLine();
                    break;
                case "6":  try{
                        obj.ViewAllProjects();
                        Console.WriteLine("Enter Project ID");
                        int PROJId1 = Convert.ToInt32(Console.ReadLine());
                        if(obj.exist(PROJId1)){
                        Console.WriteLine("Enter Employee ID ");
                        int EmpId1 = Convert.ToInt32(Console.ReadLine());
                        employee = obj1.eDetails(EmpId1);
                        obj.EmployeeFromProject(PROJId1,employee);
                        Console.WriteLine("\n Employee Deleted Successfully");
                        
                    }
                    else{
                        Console.WriteLine("The project do not exist");
                    }
                }
                    catch(FormatException )
                    {
                        Console.WriteLine("Id can only be integer");
                    }
                        Console.WriteLine("Enter any key to get to main menu");
                        Console.ReadLine();
                        break;
                case "7":
                    Console.WriteLine("Enter Project Id");
                    int pid = Convert.ToInt32(Console.ReadLine());
                    obj.Display();
                    Console.WriteLine("Enter any key to get to main menu");
                    Console.ReadLine();
                    break;
                case "8" :
                try  
                {
                    Console.WriteLine(" Enter Project ID to Delete ");
                    int IDforDelete = Convert.ToInt32(Console.ReadLine());
                    if(obj.exist(IDforDelete))
                
                    {
                        for(int i=0; i< obj.Prolifics.Count; i ++ )                 
                        {
                            for (int j = 0; j < obj.Prolifics[i].AddingEmployeelist.Count; j ++)
                            {
                                if (obj.Prolifics[i].id == IDforDelete)
                                {
                                    obj.EmployeeFromProject(IDforDelete, obj.Prolifics[i].AddingEmployeelist[j]);
                                }
                            }
                            if (obj.Prolifics[i].id== IDforDelete)
                            {
                                obj.deleteProject(IDforDelete, obj.Prolifics[i]);
                                Console.WriteLine("Deleted Successfully !!..");
                            }
                        }   
                    }
                    else
                    {
                        Console.WriteLine(" No  Project Exist");
                    }
                }
                    catch (FormatException )
                {
                    Console.WriteLine("ID should be number");
                }
                    Console.WriteLine("Enter any key to get to main menu");
                    Console.ReadLine();
                    break;
                case "9":
                    obj.ViewAllProjects();
                    Console.WriteLine("Enter any key to get to main menu");
                    Console.ReadLine();
                    break;
                      case "x":
                    return;
                default:
                    Console.WriteLine("Invalid entry");
                    break;
            }
        }

                /*case "8":
                    ProjectempId:
                    Console.WriteLine("Enter the Id of employee");
                    int empId = Convert.ToInt32(Console.ReadLine());
                    for(int i = 0; i< obj1.employeeList.Count;i++){
                        if(obj1.employeeList[i].employeeId == empId){
                            Console.WriteLine(" \n \n The id already exists \t ");
                            Console.WriteLine("\n Enter any key to try again \t");
                            Console.WriteLine(" \n Press x to get to main menu \t ");
                            var tryId = Console.ReadLine();
                            if(tryId == "x"){
                               goto breakage;
                            }
                            else{
                                goto ProjectempId;
                            }
                            }
                        }
                        
                    Console.WriteLine("Enter employee First Name");
                    string FirstName = Console.ReadLine();
                    Console.WriteLine("Enter employee Last Name");
                    string LastName = Console.ReadLine();
                    EMAIL:
                    Console.WriteLine("Enter employee Email Id");
                    string Email = Console.ReadLine();
                    if(!email.IsMatch(Email))
                            {
                                Console.WriteLine("Invalid Email Format");
                                Console.WriteLine("Enter any key to Try Again");
                                Console.WriteLine("Enter  \"x\" to get Main Menu");
                                
                                var emailread=Console.ReadLine();

                                if(emailread=="x")
                                {
                                    break;
                                }
                                else
                                {
                                    goto EMAIL;
                                }
                            }
                    Mobile:
                    Console.WriteLine("Enter employee Mobile Number");
                    string MobileNumber = Console.ReadLine();
                    if(!phonenumber.IsMatch(MobileNumber))
                            {
                                Console.WriteLine("Invalid Mobile Number format");
                                Console.WriteLine("Enter any key to Try Again");
                                Console.WriteLine("Enter  \"x\" to get Main Menu");
                                var mobileread=Console.ReadLine();

                                if(mobileread=="x")
                                {
                                    break;
                                }
                                else
                                {
                                    goto Mobile;
                                }
                            }
                            
                    Console.WriteLine("Enter Employee Address");
                    string Address = Console.ReadLine();


                    Option:
                    Console.WriteLine("Select 1 : Add Role Id to Employe");
                    Console.WriteLine("Select 2 : New Role to  Employee");
                    int select = Convert.ToInt32(Console.ReadLine());
                    if (select == 1)
                    {
                        try
                        {
                            SelectRole:
                           obj2.DisplayRole();
                            Console.WriteLine("Select Role Id from above list to assign role to employee");
                            int r1 = Convert.ToInt32(Console.ReadLine());
                            string? roleName1 = null;
                            switch (r1)
                            {
                                case 1:
                                    roleName1 = "Manager";
                                    break;
                                case 2:
                                    roleName1 = " Asst.Manager";
                                    break;
                                case 3:
                                    roleName1 = " Software Engineer";
                                    break;
                                case 4:
                                    roleName1 = " Associate Software Engineer";
                                    break;
                                case 5:
                                    roleName1 = "Trainee Software Engineer";
                                    break;
                                default:
                                 Console.WriteLine("Invalid Entry");
                                            Console.WriteLine("Enter any key to Try Again");
                                            Console.WriteLine("Enter  \"x\" to get Main Menu");
                                            string? tryemprole = Console.ReadLine();

                                            if(tryemprole == "x")   
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                goto SelectRole;
                                            }
                            }
                            Employee eadd = new Employee(empId, FirstName, LastName, Email, MobileNumber, Address, r1, roleName1);
                            obj1.AddEmp(eadd);
                            employee = eadd;
                            Console.WriteLine(" \n \n Added Successfully");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\n \n Emp ID in formate eg: 1234 ");
                        }
                    }
                    else if (select == 2)
                    {
                        try
                        {
                            Console.WriteLine("Enter  Role Id");
                            int roleID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter  name of the  Role");
                            string roleName = Console.ReadLine();
                            Console.WriteLine(roleName);
                            Role newRole = new Role(roleID, roleName);
                            obj2.RoleAdd(newRole);
                            Employee eadd = new Employee(empId, FirstName, LastName, Email, MobileNumber,Address, roleID, roleName);
                            obj1.AddEmp(eadd);
                            employee = eadd;
                            Console.WriteLine("\n \n ...Added Successfully...\t");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("\n \n Role Id should be Numbers ");
                        }
                    }
                            Console.WriteLine("");
                            Console.WriteLine("Enter any key to get back to Main Menu");
                            Console.ReadLine();
                            break;
           
                case "5":
                    try
                    {
                        Console.WriteLine(" \n \n Enter  Role Id \t ");
                        int roleID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name of the  Role");
                        string roleName = Console.ReadLine();
                        Console.WriteLine(roleName);
                        Role newRole = new Role(roleID, roleName);
                        obj2.RoleAdd(newRole);
                        Console.WriteLine("\n \n ...Added Successfully...\t");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Role Id should only be in number formate ");
                    }
                    Console.WriteLine("\n \n Enter any key to get  back to main menu \t ");
                    Console.ReadLine();
                    break;

                case "6":
                    obj2.DisplayRole();
                    Console.WriteLine("Enter any key to get back  to main menu");
                    Console.ReadLine();
                    break;*/
              
        
   
        
            Console.Write("\n LIST OF OPERATIONS ");
        Console.WriteLine("");
            Console.WriteLine("                                      *** | PROLIFICS PROJECT MANAGEMENT    | ***                                    ");
            Console.WriteLine("");
            Console.WriteLine("\n \n  HELLO PROLIFIAN ");
            Console.WriteLine("");
            Console.Write("\n \n  Select  Operation ");
            Console.WriteLine("");
            Console.Write("                                           Enter 1 : Project Module");
            Console.WriteLine("");
            Console.Write("                                           Enter 2 : Employee Module");
            Console.WriteLine("");
            Console.Write("                                           Enter 3 : Role Module");
            Console.WriteLine("");
            Console.WriteLine("                                       Enter x : exit application");
            Console.WriteLine("");
            Console.Write("\n \n Please  Enter Selected Operation ");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
        }
    }
   }
}
}
}

