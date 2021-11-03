using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }

        static void Main(string[] args)
        {
            var student = new Student();
            student.FirstName = Console.ReadLine();
            student.LastName = Console.ReadLine();
            student.Email = Console.ReadLine();
            student.PhoneNumber = Console.ReadLine();
            Console.WriteLine(student.FirstName);
            Console.WriteLine(student.LastName);
            Console.WriteLine(student.Email);
            Console.WriteLine(student.PhoneNumber);

    }
}
}
