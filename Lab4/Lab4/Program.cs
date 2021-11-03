using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab4
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public override string ToString()
        {
            return " FirstName: " + FirstName + " LastName: " + LastName + " Email: " + Email + " PhoneNumber: " + PhoneNumber;
        }

    }

    
        class ExtendedStudent : Student
        {
            public DateTime BirthDate { get; set; }
            public DateTime DayAdmission { get; set; }
            public string FacultyName { get; set; }
            public string SpecialityNumber { get; set; }

            public int GetSemesterNO
            {
                get
                {
                    int semesterNo = 0;
                    DateTime Da = DayAdmission;
                    DateTime today = DateTime.Today;


                    while (DateTime.Compare(Da.Date, today.Date) < 0)
                    {

                        semesterNo++;
                        Da = Da.AddMonths(5);
                    }
                    return semesterNo;
                }
            }

                public int GetCourseNo
            {
                get
                {
            if(GetSemesterNO <= 2)
                    {
                        return 1;
                    }
            else if (( GetSemesterNO % 2 ==1))
                    {
                    return GetSemesterNO / 2 +1;
                    }
                    else
                    {
                        return GetSemesterNO / 2 ;
                    }
                }
            }
               public string GetGroupName
        {
            get {
                var sb = new StringBuilder();
                var pattern = @"(\b\w)";
                foreach (Match matches in Regex.Matches(FacultyName, pattern))
                {
                    string abbr = matches.Value.ToUpper();
                    sb.Append(abbr);
                   
                }
                sb.Append(".");
                sb.Append(SpecialityNumber);
                sb.Append(".");
               
                
              
                sb.Append(DayAdmission.Year);
                return sb.ToString();
                    
            }
        }   
          public int GetCurrentAge
        {
            get
            {
                var age = DateTime.Today.Year - BirthDate.Year;
                if (BirthDate.Date > DateTime.Today.AddYears(-age))
                    age--;
                return age;
            }
        }    

                
        
            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.AppendLine("\nSemester №: " + GetSemesterNO );
            sb.AppendLine("\nCourse №: " + GetCourseNo);
            sb.AppendLine("GrouName :" + GetGroupName);
            sb.AppendLine("Current age: " + GetCurrentAge);
            return sb.ToString();






            }
class Program
    {
            static void Main(string[] args)
            {
                var cp = new ExtendedStudent();
                Console.WriteLine("Enter your Admission Date: example :10/30/1999 ");
                cp.DayAdmission = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter faculty name : ");
                cp.FacultyName = Console.ReadLine();
                Console.WriteLine("Enter the Speciality number: ");
                cp.SpecialityNumber = Console.ReadLine();
                Console.WriteLine("Enter your Birth date : (e.g. 01/30/1999");
                cp.BirthDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine(cp);
                
            }
        }
    }
}