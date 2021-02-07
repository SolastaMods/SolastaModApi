using System;
using System.IO;

namespace ReflectionBindingGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 2)
            {
                Console.Error.WriteLine("Run with ReflectionBindingGenerator.exe <SolastaGameDirectory> <OutputDirectory>");
                return;
            }
            var assemblyCSharpPath = Path.Combine(args[0], "Solasta_Data", "Managed", "Assembly-CSharp.dll");
            if (!File.Exists(assemblyCSharpPath))
            {
                Console.Error.WriteLine("Could not find assembly at {0}", assemblyCSharpPath);
                return;
            }
            if (string.IsNullOrEmpty(args[1]))
            {
                Console.Error.WriteLine("Invalid output director");
                return;
            }
            if (!Directory.Exists(args[1]))
            {
                Directory.CreateDirectory(args[1]);
            }
            var generator = new IlSpyBindingGenerator(assemblyCSharpPath, args[1]);
            generator.GenerateBindings();
        }
    }
}
