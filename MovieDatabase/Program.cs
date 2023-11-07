using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabase {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            var pathDebug = Directory.GetCurrentDirectory();
            var pathRoot = Path.Combine(pathDebug, @"..\..");
            var PathDotenv = Path.Combine(pathRoot, ".env");
            DotEnv.Load(PathDotenv);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormHomepage());
        }
    }
}
