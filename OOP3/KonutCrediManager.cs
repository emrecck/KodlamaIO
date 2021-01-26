using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutCrediManager : ICrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut credit pay plan computed");
        }


        public void DoSmt()
        {
            throw new NotImplementedException();
        }
    }
}
