using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    /// this is My generic class 
    static class MyGenericClass<T>
    {
        static T name;
        public static T Name {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }



    }
}
