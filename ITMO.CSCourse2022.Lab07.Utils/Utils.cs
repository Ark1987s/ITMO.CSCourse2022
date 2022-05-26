using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2022.Lab07.Utils
{
    class Utils
    {                        
        public static void Reverse(ref string s)
        {            
            string sRev = "";
            for (int k = s.Length - 1; k >= 0; k--)
            sRev = sRev + s[k];
            s = sRev;
        }
    }
}
