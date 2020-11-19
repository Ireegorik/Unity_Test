using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        interface ISomeInterface
        {
            void Call();
        }
        class SomeStruct : ISomeInterface
        {
            public void Call()
            { }
        }
        class SomeClass
        {
            public void Run()
            {
                var someStruct = new SomeStruct();
                SomeMethod(someStruct);
            }
            public void SomeMethod(ISomeInterface @interface)
            {
                @interface.Call();
            }
        }
        static void Main(string[] args)
        {
            SomeClass someClass = new SomeClass();
            someClass.Run();
        }
    }
}
