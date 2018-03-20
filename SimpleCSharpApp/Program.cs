using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpApp
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("*****My First C# App*****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            //Process any incoming args.
            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg: {0}", args[i]);
            }

            Console.WriteLine("ForEachLoop");

            foreach(string arg in args)
            {
                Console.WriteLine("Arg: {0}", arg);
            }

            Console.WriteLine("Command Line Args");
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
            {
                Console.WriteLine("Arg: {0}", arg);
            }

            //Helper method within the Program Class
            ShowEnvironmentDetails();
            //Wait for enter key to be pressed before shutting down
            Console.ReadLine();

            //Return an arbitrary error code.
            return 0;
        }

        static void ShowEnvironmentDetails()
        {
            //Print out the drives on this machine, and other details
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}", drive);
            }
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".Net Version: {0}", Environment.Version);
        }
    }
}
