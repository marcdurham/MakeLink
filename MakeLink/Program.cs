using System;
using IWshRuntimeLibrary;

namespace MakeLink
{
    class Program
    {
        static void Main(string[] args)
        {
            Request request = RequestParser.Parse(args);

            if(request.Help)
            {
                ShowUsage();
                return;
            }

            if (string.IsNullOrWhiteSpace(request.Output))
                throw new ArgumentNullException(nameof(request.Output));

            if (string.IsNullOrWhiteSpace(request.Target))
                throw new ArgumentNullException(nameof(request.Target));

            var shortcut = new IWshShell_Class()
                .CreateShortcut(request.Output) as IWshShortcut;

            if (!string.IsNullOrWhiteSpace(request.Target))
                shortcut.TargetPath = request.Target;

            if (!string.IsNullOrWhiteSpace(request.Icon))
                shortcut.IconLocation = request.Icon;

            if (!string.IsNullOrWhiteSpace(request.Arguments))
                shortcut.Arguments = request.Arguments;

            if (!string.IsNullOrWhiteSpace(request.WorkingDirectory))
                shortcut.WorkingDirectory = request.WorkingDirectory;

            if (!string.IsNullOrWhiteSpace(request.Description))
                shortcut.Description = request.Description;

            shortcut.Save();
        }

        private static void ShowUsage()
        {
            Console.WriteLine("MakeLink.exe - Create Windows shortcuts");
            Console.WriteLine("Usage: make-link.exe [parameters]");
            Console.WriteLine($"\t{Tags.Target}<path> (Required)");
            Console.WriteLine($"\t{Tags.Output}<path> (Required)");
            Console.WriteLine($"\t{Tags.Icon}<path>");
            Console.WriteLine($"\t{Tags.Arguments}<arguments>");
            Console.WriteLine($"\t{Tags.WorkingDirectory}<path>");
            Console.WriteLine($"\t{Tags.Description}<Description>");
        }
    }
}
