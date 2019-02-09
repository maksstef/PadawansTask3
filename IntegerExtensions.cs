using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            // put your code here
            /*
            for (int i = a; i > 0; i--)
            {
                if (a % i == 0)
                {
                    if (b % i == 0)
                    {
                        return i;
                    }
                }
            }*/

            
            return b == 0 ? a : Gcd(b, a % b);

            throw new NotImplementedException();
        }
    }
}
