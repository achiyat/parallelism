using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parallelism
{
    internal class ClassStr
    {
        public string str { get; set; }

        public ClassStr(string s) 
        { 
            str = s;
        }

        public static void ran()
        {
            string numbers = "";
            for (int i = 1; i <= 10; i++)
            {
                ClassStr classStr = new ClassStr(i.ToString());
                numbers = numbers + classStr.str;
            }
            Console.WriteLine(numbers);

        }
    }
}
