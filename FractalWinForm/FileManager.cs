using System.Collections.Generic;
using System.IO;

namespace Tools
{
    class FileManager
    {
        public static MemoryStream stream;
        public static BinaryWriter bw;

        public static void Write(string txt, string path)
        {
            // txt into a file.
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(txt);
            }
        }

        public static void WriteByte(byte[] txt, string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (BinaryWriter bw = new BinaryWriter(stream))
                {
                    bw.Write(txt);
                }
            }
        }

        public static void WriteBytes(byte[] content, string path)
        {
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (BinaryWriter bw = new BinaryWriter(stream))
                {
                    bw.Write(content);
                }
            }
        }

        public static MemoryStream StartWritingBytesInMemoryStream(byte[] content)
        {

            stream = new MemoryStream();

            bw = new BinaryWriter(stream);
            bw.Write(content);

            return stream;
        }
        
        public static void EndWritingBytesInMemoryStream(MemoryStream stream)
        {
            stream.Close();
        }



        public static void WriteLine(string txt, string path)
        {
            // txt into a file.
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(txt);
            }
        }

        public static string Read(string path)
        {
            // Read and show each line from the file.
            string line = "";
            using (StreamReader sr = new StreamReader(path))
            {
                line = sr.ReadToEnd();
            }

            return line;
        }
        public static string[] ReadLines(string path)
        {
            // Read and show each line from the file.
            string line = "";

            List<string> lines = new List<string>();
            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }
            return lines.ToArray();
        }
    }
}
