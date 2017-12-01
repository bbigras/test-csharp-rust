using System.Runtime.InteropServices;
using System.Text;

namespace csharp
{
    class Program
    {
        static byte[] NullTerminatedUTF8bytes(string str)
        {
            var encoding = new UTF8Encoding();
            return encoding.GetBytes(str + "\0");
        }

        [DllImport("rust.dll")]
        static extern void test([In] byte[] channel);

        static void Main(string[] args)
        {
            test(NullTerminatedUTF8bytes("123"));
        }
    }
}
