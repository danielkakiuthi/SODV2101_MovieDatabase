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
            var pathCwd = Directory.GetCurrentDirectory();
            //Debug.WriteLine($"pathCwd: {pathCwd}");             //DEBUG
            var pathRoot = Path.Combine(pathCwd, @"..\..\..");
            //Debug.WriteLine($"pathRoot: {pathRoot}");           //DEBUG
            var pathDotenv = Path.Combine(pathRoot, ".env");
            //Debug.WriteLine($"pathDotenv: {pathDotenv}");       //DEBUG
            DotEnv.Load(pathDotenv);

            ApplicationConfiguration.Initialize();
            Application.Run(new FormUserLogin());
        }
    }
}