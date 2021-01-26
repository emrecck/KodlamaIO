using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleCrediManager : ICrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Vehicle credit pay plan computed");
        }

        public void DoSmt()
        {
            throw new NotImplementedException();
        }
    }
}
