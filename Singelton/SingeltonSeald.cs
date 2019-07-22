using System;
using System.Collections.Generic;
using System.Text;

namespace Singelton
{
    public sealed class SingletonSeald
    {
        private static SingletonSeald _instance;

        private SingletonSeald()
        {

        }

        public static SingletonSeald Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new SingletonSeald();
                }

                return _instance;
            }
        }


        public string Name { get; set; }
    }
}
