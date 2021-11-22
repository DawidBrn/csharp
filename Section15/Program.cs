using System;

namespace Section15
{
    class Program
    {
        //how many option there is to pick 3 mugs out of 7 of them, n options from k objects
        static int nCombinationOfKOption(int n, int k)
        {


            if (k == 0 || k == n) return 1;
            else
            {
                return nCombinationOfKOption(n - 1, k) + nCombinationOfKOption(n - 1, k - 1);
            }
        }
            

        static void Main(string[] args)
        {
            Console.WriteLine("There is " + nCombinationOfKOption(7, 3).ToString() + " combination to choose 3 out of 7 mugs");
        }
    }
}
