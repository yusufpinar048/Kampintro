using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yaş = 36;

            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "engin demiroğ";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.Egitmen = "kerem";
            kurs2.İzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "phyton";
            kurs3.Egitmen = "berkay";
            kurs3.İzlenmeOrani = 80;

            // Console.WriteLine(kurs1.KursAdi + " :" + kurs1.Egitmen + " " + kurs1.İzlenmeOrani);

            Kurs[] kurslar = new Kurs[]
            {
                kurs1,kurs2,kurs3
            };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+": " +kurs.Egitmen+" " +kurs.İzlenmeOrani);
            }


        }
    }


    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }

    }
}
