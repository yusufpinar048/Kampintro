using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            ILoggerService databaseloggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();

            List<ILoggerService> loggerServices = new List<ILoggerService>() { fileloggerService, databaseloggerService };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, loggerServices);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,konutKrediManager,tasitKrediManager};

        ////////  basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        //////deneme

        }
    }
}
