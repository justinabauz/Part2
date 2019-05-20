using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07_03.tax
{
    class Program
    {
        public static decimal Tax(decimal pajamos)
        {
            decimal result = 0;
            if (pajamos <= 40000)
            {
                result = pajamos * 0.05m;
            }
            else if (pajamos > 40000 && pajamos <= 100000)
            {
                result = pajamos * 0.15m;
            }
            else
            {
                result = pajamos * 0.25m;
            }
            return result;
        }
        static void Main(string[] args)
        {
        }
    }
}
