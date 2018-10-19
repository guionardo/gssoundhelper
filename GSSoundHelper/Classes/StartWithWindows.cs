using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace GSSoundHelper.Classes
{
    /// <summary>
    /// Classe para configuração de início da aplicação com o logon do usuário no Windows
    /// </summary>
    public static class StartWithWindows
    {

        const string RegKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

        static readonly string ProgramName;
        static readonly string KeyValue;

        static StartWithWindows()
        {
            try
            {
                KeyValue = "\"" + Application.ExecutablePath + "\"";
                ProgramName = Path.GetFileNameWithoutExtension(Application.ExecutablePath);
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(Application.ExecutablePath);
                if (!string.IsNullOrEmpty(fvi.ProductName))
                    ProgramName = fvi.ProductName;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static bool Add()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegKey, true))
                {
                    key.SetValue(ProgramName, KeyValue);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Verifica se o programa atual está configurado no registro do 
        /// Windows para inicialização automática
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Remove a configuração do registro para inicialização automática
        /// </summary>
        /// <returns></returns>
        public static bool Remove()
        {
            if (!IsAdded())
                return true;
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
