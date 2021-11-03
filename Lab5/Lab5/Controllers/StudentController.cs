using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Students_Website_lab5_.Models;

namespace Students_Website_lab5_.Controllers
{
    public class StudentController : Controller
    {
      
        // GET: Student
        


        public static string fileName = "C:/Students/students.txt";
        public List<Student> students = new List<Student>();
        // GET: Student
        public ActionResult Index()
        {

            return View(readFile(students));
        }
        public static List<Student> readFile(List<Student> students)
        {

            if (!System.IO.File.Exists(fileName))
            {
                System.IO.File.WriteAllText(fileName, null);
            }
            string[] list = System.IO.File.ReadAllLines(fileName);
            students.Clear();
            foreach (string elem in list)
            {
                      string[] fields = elem.Split(',');
                if (elem != "")
                {
                    var student = new Student();
                    student.FirstName = fields[0] ;
                    student.LastName = fields[1];
                    student.Email = fields[2];
                    student.PhoneNumber = fields[3];

             
                   
                    students.Add(student);
                }
            }
            return students;
        }


    }
}

