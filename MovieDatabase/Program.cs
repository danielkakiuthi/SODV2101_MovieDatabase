using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabase {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            var pathDebug = Directory.GetCurrentDirectory();
            //Debug.WriteLine(pathDebug);
            var pathRoot = Path.Combine(pathDebug, @"..\..\..");
            //Debug.WriteLine(pathRoot);
            var pathDotenv = Path.Combine(pathRoot, ".env");
            DotEnv.Load(pathDotenv);
            //Debug.WriteLine(pathDotenv);

            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain());
        }
    }
}