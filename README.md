# cs-con-binary-writer

- ### [File.Open メソッド](https://docs.microsoft.com/ja-jp/dotnet/api/system.io.file.open?view=net-6.0)
- ### [BinaryReader クラス](https://docs.microsoft.com/ja-jp/dotnet/api/system.io.binaryreader?view=net-6.0)

```cs
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

```
