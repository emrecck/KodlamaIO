using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class NecessityCrediManager : ICrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Necessity credit pay plan computed");
        }

        public void DoSmt()
        {
            throw new NotImplementedException();
        }   
    }
}
