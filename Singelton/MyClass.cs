using System;
using System.Collections.Generic;
using System.Text;

namespace Singelton
{
    public class MyClass
    {
        private static MyClass _instance;

        private MyClass()
        {

        }

        public static MyClass Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new MyClass();
                }

                return _instance;
            }
        }

        public string Name { get; set; }
            

    }
}
