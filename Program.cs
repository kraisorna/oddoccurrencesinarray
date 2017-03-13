using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] A = { 9, 3, 9, 7, 9, 3, 9 };
            Console.WriteLine(s.solution(A));
            Console.ReadLine();
        }
    }

    class Solution
    {
        public int solution(int[] A)
        {
            // write your code in Java SE 8
            int result = 0;
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(result + " ^ " + A[i] + " = ");
                result ^= A[i];
                Console.WriteLine(result);
            }
            return result;
        }
    }
}
