using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct ApiSetup<T>
    { }
    class Api
    {
        public ApiSetup<T> For<T>(T obj)
        {
            return new ApiSetup<T>();
        }

    }
    interface ISomeInterfaceA
    { }
    interface ISomeInterfaceB
    { }
    public class ObjectA : ISomeInterfaceA
    { }
    public class ObjectB : ISomeInterfaceB
    { }
    class SomeClass
    {
        public void Setup()
        {
            Api apiObject = new Api();
            apiObject.For(new ObjectA()).SetupObjectA();
            apiObject.For(new ObjectB()).SetupObjectB();
        }
    }
    public static class apiExtension
    {
        public static void SetupObjectA(this ApiSetup<ObjectA> objectA)
        {
            Console.WriteLine("SetupObjectA");
        }
        public static void SetupObjectB(this ApiSetup<ObjectB> objectB)
        {
            Console.WriteLine("SetupObjectB");
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            SomeClass someClass = new SomeClass();
            someClass.Setup();
            Console.ReadKey();
        }
    }
}
