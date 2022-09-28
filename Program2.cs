using System;
using System.IO;

namespace cs_con_binary_writer
{
    class Program2
    {
        public string file_path;

        public Program2(string file_path)
        {
            this.file_path = file_path;
        }

        internal void WriteZipData()
        {
            // Open
            var stream = File.Create(file_path);
            var writer = new BinaryWriter( stream );

            writer.Write(101010256);

            writer.Write(0);
            writer.Write(0);
            writer.Write(0);
            writer.Write(0);

            writer.Write(false);
            writer.Write(false);

            writer.Close();
            writer.Dispose();
            // Close
            stream.Close();
            stream.Dispose();
        }
    }
}