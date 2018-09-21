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
        public static int Legkissebb(int[] tomb, out int hely)
        {
            int min = tomb[0];
            hely = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < min)
                {
                    min = tomb[i];
                    hely = i;
                }
            }
            return min;
        }

        static void Main(string[] args)
        {
            string keres="";
            int darabszam;
            do
            {
                Console.Write("Kérem adja meg, hogy hány elemű legyen a tömb: ");
                keres = Console.ReadLine();
                if (int.TryParse(keres, out darabszam) == false)
                {
                    Console.WriteLine("Nem szabad betűt használni!!!!!!!!!!!!444!!!!!!!!!!!");
                    Console.ReadKey();
                    return;

                }
            } while (int.TryParse(keres,out darabszam)==false);
            int[] szam_ker = new int[darabszam];
            for (int i = 0; i < szam_ker.Length; i++)
            {
                 
                do
                {
                    Console.Write("Kérem a {0}. számot: ",i+1);
                    keres = Console.ReadLine();
                   if( int.TryParse(keres, out szam_ker[i]) == false)
                    {
                        Console.WriteLine("Nem szabad betűt használni!!!!!!!!!!!!444!!!!!!!!!!!");
                        Console.ReadKey();
                        return;

                    }
                } while (int.TryParse(keres,out szam_ker[i])==false);
            }
            
            for (int i = 0; i < szam_ker.Length; i++)
            {
                Console.WriteLine(szam_ker[i] + " ");
            }
            int helye;
            int legnagyobb= Legnagyobb(szam_ker, out helye);

            Console.WriteLine("A legnagyobb szám a bekért értékek között a: {0} és a helye: {1}",legnagyobb,helye+1);
            int legkissebb= Legkissebb(szam_ker, out helye);
            Console.WriteLine("A legkissebb szám a bekért értékek között a: {0} és a helye: {1}", legkissebb, helye + 1);
            Console.ReadKey();

        }
    }
}
