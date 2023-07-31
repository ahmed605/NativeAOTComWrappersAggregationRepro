using System.Reflection;
using Windows.UI.Input;
using Windows.UI.WindowManagement;

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
            new TestClass();
        }
    }
}