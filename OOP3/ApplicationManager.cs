using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public ApplicationManager()
        {

        }
        public void MakeAnApplication( ICrediManager crediManager)
        {
            crediManager.Calculate();
        }
    }
}
