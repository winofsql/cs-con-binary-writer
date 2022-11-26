using System.IO;
using System.Text;

namespace cs_con_binary_writer
{
    class Program
    {
        private static string fileName = "Settings.dat";
        static void Main(string[] args)
        {
            WriteBinaryData();
        }

        private static void WriteBinaryData()
        {
            using (var stream = File.Open(fileName, FileMode.Create))
            {
                using (var writer = new BinaryWriter(
                    stream, Encoding.UTF8, false))
                {
                    writer.Write(1.250F);
                    writer.Write(@"c:\Temp");
                    writer.Write(10);
                    writer.Write(true);
                }
            }
        }
        
    }
}
