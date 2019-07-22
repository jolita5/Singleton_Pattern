using System;

namespace Singelton
{
    class Program
    {
        static void Main(string[] args)
        {
            var ourClass = MyClass.Instance;

            ourClass.Name = "Lisa";

            var tss = ThreadSafeSingleton.Instance;
            tss.Name = "John";

            var sSeald = SingletonSeald.Instance;
            sSeald.Name = "Lorry";

            Console.ReadKey();

        }
    }
}
