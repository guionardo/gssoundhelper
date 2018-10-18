using Microsoft.Win32;
using System.Windows.Forms;

namespace GSSoundHelper
{
    public static class StartWithWindows
    {
        const string ProgramName = "GSSoundHelper";
        const string RegKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

        public static bool IsAdded()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegKey, true))
                {
                    return !(key.GetValue(ProgramName, "none").ToString() == "none");
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool Add()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegKey, true))
                {
                    key.SetValue(ProgramName, "\"" + Application.ExecutablePath + "\"");
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool Remove()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegKey, true))
                {
                    key.DeleteValue(ProgramName, false);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
