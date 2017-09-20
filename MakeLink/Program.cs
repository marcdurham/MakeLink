using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shell32;
using IWshRuntimeLibrary;

namespace MakeLink
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateShortCut();
        }


        // Routine to create "mylink.lnk" on the Windows desktop.
        static void CreateShortCut()
        {
            //dynamic objShell, strDesktopPath;
            //var objShell = CreateObject("WScript.Shell");
            //strDesktopPath = objShell.SpecialFolders("Desktop");
            //var objLink = objShell.CreateShortcut(strDesktopPath & "\\mylink.lnk");
            //objLink.Arguments = "c:\\windows\\tips.txt";
            //objLink.Description = "Shortcut to Notepad.exe";
            //objLink.TargetPath = "c:\\windows\notepad.exe";
            //objLink.WindowStyle = 1;
            //objLink.WorkingDirectory = "c:\\windows";
            //objLink.Save();

            var wsh = new IWshShell_Class();
            IWshShortcut shortcut = wsh.CreateShortcut(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop) 
                    + "\\shorcut2LoopCAD.lnk") as IWshShortcut;
            shortcut.TargetPath = @"E:\LoopCAD";
            shortcut.IconLocation = @"E:\LoopCAD\Icons\12.bmp";
            shortcut.Save();
        }
    }
}
