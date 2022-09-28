# [cs-con-binary-writer](https://github.com/winofsql/cs-con-binary-writer)

- ### [File.Open メソッド](https://docs.microsoft.com/ja-jp/dotnet/api/system.io.file.open?view=net-6.0)
- ### [BinaryWriter クラス](https://learn.microsoft.com/ja-jp/dotnet/api/system.io.binarywriter?view=net-6.0)
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

![image](https://user-images.githubusercontent.com/1501327/187205545-71a9cb3d-85ee-4670-9697-dbdfbf239e17.png)

![image](https://user-images.githubusercontent.com/1501327/187205475-19d3f5b9-021b-4e65-98f3-e4fb6e2a7464.png)

### 空の zip ファイル
![image](https://user-images.githubusercontent.com/1501327/192670227-a9abae8b-26c2-4710-b8ed-05517787b885.png)

```cs
        private void WriteZipData()
        {
            // Open
            var stream = File.Create("test.zip");
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
```
