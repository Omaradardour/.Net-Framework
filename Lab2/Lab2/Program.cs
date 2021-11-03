
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }
        public override string ToString()
        {
            return " FirstName: "+ FirstName + " LastName: " + LastName + " Email: " + Email + " PhoneNumber: " + PhoneNumber;
        }

        static void Main(string[] args)
        {


            Console.WriteLine("Enter the StudentsAmount: ");
            int studentsAmount = int.Parse(Console.ReadLine());
            Console.WriteLine("The studentsAmount is: " + studentsAmount);
             var students = new List<Student>();
            for (int i = 0; i < studentsAmount; i++)
            {
                Console.WriteLine("\nStudent N*: " + (i + 1));

                var student = new Student();
                Console.WriteLine(" Enter student's first name:");
                student.FirstName = Console.ReadLine();
                Console.WriteLine(" Enter student's last name:");
                student.LastName = Console.ReadLine();
                Console.WriteLine(" Enter student's email:");
                student.Email = Console.ReadLine();
                Console.WriteLine(" Enter student's phone number:");
                student.PhoneNumber = Console.ReadLine();

                students.Add(student);
            }
                
                foreach (Student aStudents in students)
                {
                    Console.WriteLine(aStudents);
                }




            }

        }

    }

     

    

