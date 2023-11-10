using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace MovieDatabase {
    public static class DotEnv {
    
        public static void Load(string filePath) {
            if (!File.Exists(filePath)) {
                return;
            }

            foreach (var line in File.ReadAllLines(filePath)) {
                char[] separators = new char[] { '=' };
                var parts = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length != 2) {
                    continue;
                }

                Environment.SetEnvironmentVariable(parts[0], parts[1]);
            }
        }
    }
}
