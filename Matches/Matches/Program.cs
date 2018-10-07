using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matches
{
    class Program
    {
        public static int Matches(int n)
        {
            if (n == 1) return 4;
            if (n == 2) return 7;

            int p = 1; int Squares = 2; int Matches = 7;

            while (Squares < n)
            {
                Matches += 3; Squares = Squares + 1;
                if (n == Squares) return Matches;

                for (int i = 1; i <= p; i++)
                {
                    Matches = Matches + 2; Squares = Squares + 1;
                    if (n == Squares) return Matches;
                }

                Matches += 3; Squares = Squares + 1;
                if (n == Squares) return Matches;

                for (int i = 1; i <= p; i++)
                {
                    Matches = Matches + 2;
                    Squares = Squares + 1;
                    if (n == Squares) return Matches;
                }

                p++;
            }

            return Matches;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Matches(4));
            Console.ReadKey();
        }
    }
}
