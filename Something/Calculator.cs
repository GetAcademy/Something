using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Something
{
    public class Calculator
    {
        public static int? GetMagicNumber(int a, int b)
        {
            try
            {
                if (a < 0)
                {
                    a = a * -1;
                }

                return a / b;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static int? GetMagicNumber2(int a)
        {
            var magicNumber = 1;
            if (a < 10)
            {
                magicNumber++;
            }
            else
            {
                magicNumber *= 2;
            }
            if (a % 2 == 0) // er partall
            {
                magicNumber++;
            }
            else
            {
                magicNumber *= 2;
            }
            if (a < 0)
            {
                magicNumber++;
            }
            else
            {
                magicNumber *= 2;
            }

            return magicNumber;
        }
    }
}
