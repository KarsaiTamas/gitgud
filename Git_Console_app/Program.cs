using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Console_app
{
    class Program
    {

        public static int Legnagyobb(int[]tomb,out int hely)
        {
            int max=tomb[0];
            hely = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]>max)
                {
                    max = tomb[i];
                    hely = i;
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            int[] szam_ker = new int[10];
            for (int i = 0; i < 10; i++)
            {
                string keres;
                do
                {
                    Console.Write("Kérem a {0}. számot: ",i+1);
                    keres = Console.ReadLine();
                } while (int.TryParse(keres,out szam_ker[i])==false);
            }

            for (int i = 0; i < szam_ker.Length; i++)
            {
                Console.WriteLine(szam_ker[i] + " ");
            }
            int helye;
            int legnagyobb= Legnagyobb(szam_ker, out helye);
            Console.WriteLine("A legnagyobb szám a bekért értékek között a: {0} és a helye: {1}",legnagyobb,helye+1);
            Console.ReadKey();

        }
    }
}
