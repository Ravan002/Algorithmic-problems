using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Project_Euler
    {

        // ID: 1 Multiples of 3 or 5

        public void Problem1(int sizeOfNUmber)
        {
            long result = 0;
            for(int i = 1; i < sizeOfNUmber; i++)
            {
                if(i%3==0 || i % 5 == 0)
                {
                    result += i;
                }
            }
            Console.WriteLine(result);
        }

        // ID 2: Even Fibonacci Numbers
        public void Problem2(int value)
        {
            int a = 1;
            int b = 2;
            long sum = 0;
            while (b <= value)
            {
                if (b % 2 == 0) sum += b;
                b += a;
                a = b - a;
            }
            Console.WriteLine(sum); 
        }

        // ID 3: Largest Prime Factor

        public void Problem3(long value)
        {
            long largstPrime = 1;
            for(int i=2;i<=value; i++)
            {
                if(value % i == 0)
                {
                    Console.WriteLine(i);
                    value /= i;
                    if (largstPrime < i) largstPrime = i;
                }
            }
            Console.WriteLine(largstPrime);

        }

    }
}
