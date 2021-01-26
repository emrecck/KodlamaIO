using System;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //NecessityCrediManager necessityCrediManager = new NecessityCrediManager();
            //necessityCrediManager.Calculate();

            //VehicleCrediManager vehicleCrediManager = new VehicleCrediManager();
            //vehicleCrediManager.Calculate();

            //KonutCrediManager konutCrediManager = new KonutCrediManager();
            //konutCrediManager.Calculate();

            ICrediManager necessityCrediManager = new NecessityCrediManager();

            ICrediManager vehicleCrediManager = new VehicleCrediManager();

            ICrediManager konutCrediManager = new KonutCrediManager();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApplication(necessityCrediManager);
            applicationManager.MakeAnApplication(vehicleCrediManager);
            applicationManager.MakeAnApplication(konutCrediManager);
        }
    }
}
