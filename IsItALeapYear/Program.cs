using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsItALeapYear
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
           

            IsItLeapYear obj = new IsItLeapYear();
            var result = obj.IsItALeapYearTest(a);
        }

        public class IsItLeapYear
        {
            public bool IsItALeapYearTest(int lYear)
            {
                bool result = false;
                
                    if (((lYear % 4 == 0) && (lYear % 100 != 0)) || (lYear % 400 == 0))
                    {
                        
                        result = true;
                        return result;
                    }
                    else
                    {
                        result = false;
                        return result;
                    }

               
            }
        }

    }
}
