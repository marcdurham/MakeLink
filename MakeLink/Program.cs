using IWshRuntimeLibrary;

namespace MakeLink
{
    class Program
    {
        static void Main(string[] args)
        {
            var shortcut = new IWshShell_Class().CreateShortcut(
                @"C:\Users\marcd\AppData\Roaming\Microsoft\Internet Explorer\Quick Launch\User Pinned\TaskBar\LoopCAD.lnk"
                ) as IWshShortcut;

            shortcut.TargetPath = @"C:\Program Files (x86)\ProgeCAD\progeCAD 2014 Professional ENG\icad.exe";
            shortcut.IconLocation = @"E:\LoopCAD\LoopCAD.ico";
            shortcut.Arguments = @"/b E:\LoopCAD\LoopCAD.scr";
            shortcut.WorkingDirectory = @"E:\LoopCAD";
            shortcut.Save();
        }
    }
}
