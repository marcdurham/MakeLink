using IWshRuntimeLibrary;
using Microsoft.Win32;

namespace MakeLink
{
    class Program
    {
        static void Main(string[] args)
        {
            var shortcut = new IWshShell_Class().CreateShortcut(
                @"E:\LoopCAD\LoopCAD.lnk") as IWshShortcut;

            shortcut.TargetPath = @"C:\Program Files (x86)\ProgeCAD\progeCAD 2014 Professional ENG\icad.exe";
            shortcut.IconLocation = @"E:\LoopCAD\LoopCAD.ico";
            shortcut.Arguments = @"/b E:\LoopCAD\LoopCAD.scr";
            shortcut.WorkingDirectory = @"E:\LoopCAD";
            shortcut.Save();

            RegistryKey myKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Company\\Compfolder", true);
            if (myKey != null)
            {
                myKey.SetValue("Deno", "1", RegistryValueKind.String);
                myKey.Close();
            }
        }
    }
}
