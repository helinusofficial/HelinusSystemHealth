using System.IO;
using System.Windows.Forms;

namespace HelinusSystemHealth
{
    internal class Utilities
    {
        public string ShowAppVersion()
        {
            System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(
               System.Reflection.Assembly.GetEntryAssembly().Location);
            return fvi.FileVersion;
        }

        public string ReadSetting()
        {
            try
            {
                using (StreamReader sr = new StreamReader(Application.StartupPath + "\\config.txt"))
                {
                    return sr.ReadLine();
                }
            }
            catch
            {

            }

            return string.Empty;
        }
    }
}
