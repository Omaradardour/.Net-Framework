using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Students_Website_lab5_.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

   
       
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("FirstName: " + FirstName);
            sb.Append(" ,LastName: " + LastName);
            sb.Append(", Email: " + Email);
            sb.Append(", PhoneNumber: " + PhoneNumber);

            return sb.ToString();
        }
    }
}