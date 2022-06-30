using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.IO;

namespace HLSDKTools
{
    public partial class Decompiler
    {
        public static void SelectExecutable()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"/bin/",
                Title = "Browse MDLDEC.exe Executeable",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "exe",
                Filter = "exe files (*.exe)|*.exe",

            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Settings.MDLDecPath = openFileDialog1.FileName;
            }
        }

        public static void SelectModelFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = "D:/",
                Title = "Browse model (.mdl) file",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "mdl",
                Filter = "mdl files (*.mdl)|*.mdl",
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Settings.modelInput = openFileDialog1.FileName;
            }
        }

        public static void SelectOutputFolder()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = "D:/",
                Title = "Browse output folder",

                CheckFileExists = false,
                CheckPathExists = true,
                ValidateNames = false,

                FileName = "Folder Selection.",

            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Settings.modelOutput = openFileDialog1.FileName.Remove(openFileDialog1.FileName.Length - 17);
            }
        }

        public static void StartDecompile()
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = Settings.MDLDecPath,
                    Arguments = '"' + Settings.modelInput + '"' + " " + '"' + Settings.modelOutput + '"',
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            while (!proc.StandardOutput.EndOfStream)
            {
                string standard_output;
                while ((standard_output = proc.StandardOutput.ReadLine()) != null)
                {
                    PanelGUI.DecConsoleOutput += standard_output + '\n';
                }
            }
        }
    }
}
