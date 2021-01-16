using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştrici yetiştirme kampı";
            string kurs2 = "programlamaya başalangıç için temel kurs";
            string kurs3 = "java kursu";

            //array 

            string[] kurslar = new string[] { "yazılım geliştrici yetiştirme kampı", "programlamaya başalangıç için temel kurs", "java kursu" };


            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
               
            }

            Console.WriteLine("for bitti");


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu");

            

        }
    }
}
