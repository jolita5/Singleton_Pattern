using System;
using System.Collections.Generic;
using System.Text;

namespace Singelton
{
    public class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton _instance;
        private static readonly object _padlock = new object();

        private ThreadSafeSingleton()
        {
        }

        public static ThreadSafeSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock(_padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new ThreadSafeSingleton();
                            _instance.Name = "Kevin";
                        }
                    }
                }

                return _instance;
            }
        }

        public string Name { get; set; }
        public int NodeId { get; set; }
    }
}
