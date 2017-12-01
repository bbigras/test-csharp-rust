using System.Runtime.InteropServices;
using System.Text;

namespace csharp
{
    class Program
    {
        [DllImport("rust.dll")]
        static extern void test();

        static void Main(string[] args)
        {
            test();
        }
    }
}
