
using System;

namespace LINQTut08.Shared
{
    public class Employee
    {
        public Employee() { }
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime HireDate { get; set; }

        public string Gender { get; set; }

        public string Department { get; set; }
         
        public bool HasHealthInsurance { get; set; }

        public bool HasPensionPlan { get; set; }

        public decimal Salary { get; set; }

        public override string ToString()
        {
            return
                    string.Format($"" +
                    $"{Id}\t" +
                    $" {String.Concat(LastName, ", ", FirstName).PadRight(15, ' ')}\t\n" + 
                    $"{HireDate.Date.ToShortDateString()}\t\n" +
                    $"{Gender.PadRight(10, ' ')}\t\n" +
                    $"{Department.PadRight(10, ' ')}\t\n" +
                    $"{HasHealthInsurance}\t\n" +
                    $"{HasPensionPlan}\t\n" +
                    $"${Salary.ToString("0.00")}\n");
        }
    }

    
}
