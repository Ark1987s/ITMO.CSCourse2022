using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2022.Lab07.Utils
{
    public class Test
    {
        static void Main()
        {
            string message;
            Console.WriteLine("Enter string to reverse:");
            message = Console.ReadLine();
            Utils.Reverse(ref message);
            Console.WriteLine(message);
        }
    }
}
