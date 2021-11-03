using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;


namespace Lab3
{
    public class Student {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return " FirstName: " + FirstName + " ,LastName: " + LastName + " ,Email: " + Email + ", PhoneNumber: " + PhoneNumber;
        }

    }


    class Program
    {



        static void Main(string[] args)
        {

            bool Call = true;
            List<Student> students = new List<Student>();
            string fileName = "data.txt";
            while (Call)
            {
                Console.WriteLine("Enter R to read students list");
                Console.WriteLine("Enter A to add new student to the list");
                Console.WriteLine("Enter E to edit a student to the list");
                Console.WriteLine("Enter S to search for a student to the list");
                Console.WriteLine("Enter D to delete a student to the list");
                Console.WriteLine("Enter X to close the program");
                string Input = Console.ReadLine();

                if (Input == "R")
                {
                    readFile(students, fileName);
                }
                if (Input == "A")
                {
                    addStudent(students, fileName);
                }
                if (Input == "E")
                {
                    editData(students, fileName);
                }
                if (Input == "S")
                {
                    searchItem(students);
                }
                if (Input == "D")
                {
                  deleteItem( students ,fileName);
                }
                if (Input == "X")
                {
                    Call = false;
                }
            }
        }



        
        static void readFile(List<Student> students, string fileName)
        {


            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {

                string[] values = line.Split(',');
                _ = values.Length > 3;
                Student student = new Student();
                student.FirstName = values[0];
                student.LastName = values[1];
                student.Email = values[2];
                student.PhoneNumber = values[3];

                students.Add(student);

            }

            Console.WriteLine("read from text file: ");
            foreach (var stu in students)
            {

                Console.WriteLine(stu);

            }

        }


        static void addStudent(List<Student> students, string fileName)

        {


            var stud = new Student();
            Console.WriteLine(" Enter student's first name:");
            stud.FirstName = Console.ReadLine();
            Console.WriteLine(" Enter student's last name:");
            stud.LastName = Console.ReadLine();
            Console.WriteLine(" Enter student's email:");
            stud.Email = Console.ReadLine();
            Console.WriteLine(" Enter student's phone number:");
            stud.PhoneNumber = Console.ReadLine();

            students.Add(stud);

            List<string> output = new List<string>();
           
            foreach(var stu in students) { 
               output.Add($"{stu.FirstName} ,{stu.LastName} ,{stu.Email}, {stu.PhoneNumber} ");
                File.WriteAllLines(fileName, output);
            
}
            Console.WriteLine("/nStudent has added to the list successefully!");

        }



        static void searchItem(List<Student> students)
        {

            Console.WriteLine("Search by FirstName enter FN");
            Console.WriteLine("Search by LastName enter LN");
            Console.WriteLine("Search by Email enter EM");
            Console.WriteLine("Search by PhoneNumber enter PN");
            string searchBy = Console.ReadLine();
            if (searchBy == "FN")
            {
                Console.WriteLine("Who do you want to find?");
                string search = Console.ReadLine();
                var result = students.Find(oStud => oStud.FirstName.Contains(search));
                Console.WriteLine("Result:");
                Console.WriteLine(result + "\n");
            }
            if (searchBy == "LN")
            {
                Console.WriteLine("Who do you want to find:");
                string search = Console.ReadLine();
                var result = students.Find(oStud => oStud.LastName.Contains(search));
                Console.WriteLine("Result:");
                Console.WriteLine(result + "\n");

            }


            if (searchBy == "EM")
            {
                Console.WriteLine("Who do you want to find:");
                string search = Console.ReadLine();
                var result = students.Find(oStud => oStud.Email.Contains(search));
                Console.WriteLine("Result:");
                Console.WriteLine(result + "\n");

            }
            if (searchBy == "PN")
            {
                Console.WriteLine("Who do you want to find:");
                string search = Console.ReadLine();
                var result = students.Find(oStud => oStud.PhoneNumber.Contains(search));
                Console.WriteLine("Result:");
                Console.WriteLine(result + "\n");

            }
        }
    
        static void editData(List<Student> students, String fileName)
        {

            Console.WriteLine("Enter Student index to edit:");
            int index = int.Parse(Console.ReadLine());
            var student = new Student();
            Console.WriteLine("Rewrite student's FirstName: ");
            student.FirstName = Console.ReadLine();
            Console.WriteLine("Rewrite student's LastName: ");
            student.LastName = Console.ReadLine();
            Console.WriteLine("Rewrite student's Email: ");
            student.Email = Console.ReadLine();
            Console.WriteLine("Rewrite student's PhoneNumber: ");
            student.PhoneNumber = Console.ReadLine();
            students[index - 1] = student;
            string[] rewrite = new string[students.Count];
            int i = 0;
            foreach (var s in students)
            {
                rewrite[i] = s.ToString();
                i++;
            }
            System.IO.File.WriteAllLines(fileName, rewrite);

            Console.WriteLine("\nEditing has done successefully!\n");
        }


       static List<Student>  deleteItem(List<Student> students , string fileName)
        {
           
            
            Console.WriteLine("Enter student's index to delete: ");
            int index = int.Parse(Console.ReadLine());
           

            students.RemoveAt(index-1);

            string[] rewrite = new string[students.Count];
            int i = 0;
            foreach (var student in students)
            {
                rewrite[i] = student.ToString();
                i++;
            }
            System.IO.File.WriteAllLines(fileName, rewrite);
            Console.WriteLine("/nStudent has deleted successefully!");
           
                
            return students;
        }

    }
                
        }         
            
        

    
        


