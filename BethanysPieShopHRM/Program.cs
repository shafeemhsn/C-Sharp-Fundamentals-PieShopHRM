using BethanysPieShopHRM;
using BethanysPieShopHRM.Accounting;
using BethanysPieShopHRM.HR;
using System.Text;


List<Employee> employees = new List<Employee>();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("**************************************");
Console.WriteLine("* Bethany's Pie Shop Employee App *");
Console.WriteLine("**************************************");
Console.ForegroundColor = ConsoleColor.White;

string userSelection;
Console.ForegroundColor = ConsoleColor.Blue;

Utilities.CheckForExistingEmployeeFile();

do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Loaded {employees.Count} employee(s)\n\n");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("********************");
    Console.WriteLine("* Select an action *");
    Console.WriteLine("********************");

    Console.WriteLine("1: Register employee");
    Console.WriteLine("2: View all employees");
    Console.WriteLine("3: Save data");
    Console.WriteLine("4: Load data");
    Console.WriteLine("5: Load specific employee");
    Console.WriteLine("9: Quit application");
    Console.Write("Your selection: ");

    userSelection = Console.ReadLine();

    switch (userSelection)
    {
        case "1":
            Utilities.RegisterEmployee(employees);
            break;
        case "2":
            Utilities.ViewAllEmployees(employees);
            break;
        case "3":
            Utilities.SaveEmployees(employees);
            break;
        case "4":
            Utilities.LoadEmployees(employees);
            break;
        case "5":
            Utilities.LoadEmployeesById(employees);
            break;
        case "9":
            break;
        default:
            Console.WriteLine("Invalid selection. Please try again.");
            break;
    }


}
while (userSelection != "9");

Console.WriteLine("Thanks for using the applicaion");






//IEmployee bethany = new StoreManager("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);

//IEmployee mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);

//IEmployee bobJunior = new JuniorResearcher("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);

//IEmployee kevin = new StoreManager("Kevin", "Marks", "kevin@snowball.be", new DateTime(1953, 12, 12), 10);

//IEmployee kate = new StoreManager("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10);

//Console.WriteLine("How many hours do we need to register for Bethany?");
//int numberOfHours = 0;
//string input = Console.ReadLine();
//numberOfHours = int.Parse(input);

//bethany.DisplayEmployeeDetails();
//bethany.PerformWork();
//bethany.PerformWork(numberOfHours);



//List<IEmployee> employees = new List<IEmployee>();
//employees.Add(bethany);
//employees.Add(mary);
//employees.Add(bobJunior);
//employees.Add(kate);
//employees.Add(kevin);

//foreach (Employee employee in employees)
//{
//    employee.DisplayEmployeeDetails();
//    employee.GiveBonus();
//    employee.GiveCompliment();
//}

//bethany.DisplayEmployeeDetails();
//bethany.PerformWork(8);
//bethany.PerformWork();
//bethany.PerformWork(3);
//bethany.ReceiveWage();

//mary.DisplayEmployeeDetails();
//mary.PerformWork(25);
//mary.PerformWork();
//mary.PerformWork();
//mary.ReceiveWage();
////mary.AttendManagerMeeting();

//mary.GiveBonus();


//bobJunior.ResearchNewPieTastes(5);
//bobJunior.ResearchNewPieTastes(5);