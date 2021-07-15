using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empObj1 = new Employee(1, "Sam", 3, DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            Employee empOne = new DirectReport(empObj1, "SPS200");

            Employee empObj2 = new Employee(2, "Smith", 3, DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            Employee empTwo = new DirectReport(empObj2, "SPS200");

            Employee empObj3 = new Employee(3, "Harvey", 3, DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            Employee empThree = new DirectReport(empObj3, "SPS200");

            Employee empObj4 = new Employee(4, "Specter", 3, DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            Employee empFour = new DirectReport(empObj4, "SPS200");

            Employee empObj5 = new Employee(5, "Mike", 3, DateTime.ParseExact("01-01-2021", "dd-MM-yyyy", CultureInfo.InvariantCulture));
            Employee empFive = new DirectReport(empObj4, "SPS200");

            List<Employee> lstDirectReports = new List<Employee>();
            lstDirectReports.Add(empOne);
            lstDirectReports.Add(empTwo);
            lstDirectReports.Add(empThree);
            lstDirectReports.Add(empFour);
            lstDirectReports.Add(empFive);

            Manager manEmp = new Manager(lstDirectReports, "SPS001");
            var lst=manEmp.GetMyReports();

            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
        }
    }
}
