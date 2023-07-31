using System.Diagnostics;

namespace NativeAOTComWrappersAggregationRepro
{
    internal class TestClass : TestComponent.Class
    {
        internal TestClass() { Console.WriteLine("Hello!"); }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Waiting for a debugger, press any key to continue");
            Console.Read();
            new TestClass();
        }
    }
}