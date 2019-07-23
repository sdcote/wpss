using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace coyote.wpss
{
    static class Program
    {
        public static readonly string KEY = "Software\\Web-Page-Screensaver";

        [STAThread]
        static void Main(string[] args)
        {
            // Set version of embedded browser (http://weblog.west-wind.com/posts/2011/May/21/Web-Browser-Control-Specifying-the-IE-Version)
            var exeName = Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", exeName, 0x2AF8, RegistryValueKind.DWord);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length > 0)
            {
                string firstArgument = args[0].ToLower().Trim();
                string secondArgument = null;

                // Handle cases where arguments are separated by colon.
                // Examples: /c:1234567 or /P:1234567
                if (firstArgument.Length > 2)
                {
                    secondArgument = firstArgument.Substring(3).Trim();
                    firstArgument = firstArgument.Substring(0, 2);
                }
                else if (args.Length > 1)
                {
                    secondArgument = args[1];
                }

                if (firstArgument == "/c") // Configuration mode
                {
                    Application.Run(new PreferencesForm());
                }
                else if (firstArgument == "/p") // Preview mode
                {
                    // silently ignore
                }
                else if (firstArgument == "/s") // Full-screen mode
                {
                    // Windows 10 sends /s when "Test" is selected.
                    Application.Run(new ScreensaverForm());
                }
                else    // Undefined argument
                {
                    MessageBox.Show("Sorry, but the command line argument \"" + firstArgument + "\" is not valid.\n Args: `" + args + "'", "WPSS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else // No arguments
            {
                // Windows 10 sends no arguments when "Configure" is selected
                Application.Run(new PreferencesForm());
            }
        }
    }
}
