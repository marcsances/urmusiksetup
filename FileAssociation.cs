using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Text;
/*
 * This file is NOT from MSS Software & Services, though we make use of it as it completely fits our needs.
 * Credit goes to cristiscu Codeproject user. http://www.codeproject.com/Articles/621/Associate-File-Extension-with-Shell-OPEN-command-a?msg=1589623#xx1589623xx
 * We owe you a cup of coffee ;)
 */
public class FileAssociation
{
    // Associate file extension with progID, description, icon and application
    public static void Associate(string extension,
           string progID, string description, string icon, string application)
    {
        Registry.ClassesRoot.CreateSubKey(extension).SetValue("", progID);
        if (progID != null && progID.Length > 0)
            using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(progID))
            {
                if (description != null)
                    key.SetValue("", description);
                if (icon != null)
                    key.CreateSubKey("DefaultIcon").SetValue("", ToShortPathName(icon));
                if (application != null)
                    key.CreateSubKey(@"Shell\Open\Command").SetValue("",
                                ToShortPathName(application) + " \"%1\"");
            }
    }

    // Return true if extension already associated in registry
    public static bool IsAssociated(string extension)
    {
        return (Registry.ClassesRoot.OpenSubKey(extension, false) != null);
    }

    [DllImport("Kernel32.dll")]
    private static extern uint GetShortPathName(string lpszLongPath,
        [Out] StringBuilder lpszShortPath, uint cchBuffer);

    // Return short path format of a file name
    private static string ToShortPathName(string longName)
    {
        StringBuilder s = new StringBuilder(1000);
        uint iSize = (uint)s.Capacity;
        uint iRet = GetShortPathName(longName, s, iSize);
        return s.ToString();
    }
}
