using System;
using System.IO;

namespace ReflectionBindingGenerator
{
    public class IndentedWriter : IDisposable
    {
        private StreamWriter SW;
        public int IndentLevel = 0;
        public IndentedWriter(StreamWriter sw)
        {
            SW = sw;
        }

        public IndentedWriter(string path)
        {
            SW = new StreamWriter(path);
        }

        private void WriteIndent()
        {
            SW.Write(new string(' ', 4 * IndentLevel));
        }
        public void WriteLine(string text)
        {
            WriteIndent();
            SW.WriteLine(text);
        }
        public void WriteLine(string text, params object[] args)
        {
            WriteIndent();
            SW.WriteLine(text, args);
        }

        public void Dispose()
        {
            SW.Dispose();
        }
    }
}
