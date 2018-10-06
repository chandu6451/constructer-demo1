using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo1
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Employee Default Constructor Called");
        }

        public Employee(int id)
        {
            Console.WriteLine("Employee Parameterized Constructor with 1 Parameter Called");
        }

        public Employee(int id, string name)
        {
            Console.WriteLine("Employee Parameterized Constructor with 2 Parameters Called");
        }

        static Employee()
        {
            Console.WriteLine("Employee Static Constructor called");
        }
    }
}
