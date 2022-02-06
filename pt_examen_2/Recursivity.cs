using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pt_examen_2
{
    public class Recursivity
    {
        public static int Rec(int n)
        {
            if(n <= 1)
            {
                return 1;
            }
            return n * Rec(n - 1);
        }
    }
}
