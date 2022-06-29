using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HLSDKTools
{
    public partial class Settings
    {
        // Config buffer
        public static string[] ConfigurationBuffer;

        // Global settings
        public static string HLAMPath;
        public static string MDLDecPath;
        public static string StudioMDLPath;
        public static string WadmakerPath;
        public static string SpritemakerPath;
        public static string modelOutput;

        // runtime settings (do note these arent being saved onto the config)
        public static string modelInput;

        // ===================================================================================
        // InitSetting - Load configuration
        // ===================================================================================
        public static void InitSetting()
        {
            // load config file
            ConfigurationBuffer = File.ReadAllLines(Path.Combine(Environment.CurrentDirectory, "bin/config.txt"));

            // parse the data
            HLAMPath = Parser.ExtractToken("hlam", ConfigurationBuffer);
            MDLDecPath = Parser.ExtractToken("mdldec", ConfigurationBuffer);
            StudioMDLPath = Parser.ExtractToken("studiomdl", ConfigurationBuffer);
            WadmakerPath = Parser.ExtractToken("wadmaker", ConfigurationBuffer);
            SpritemakerPath = Parser.ExtractToken("spritemaker", ConfigurationBuffer);
            modelOutput = Parser.ExtractToken("outputfolder", ConfigurationBuffer);

        }

        // ===================================================================================
        // SaveSetting - Save configuration
        // ===================================================================================
        public static void SaveSetting()
        {
            // local buffer
            string[] NewSetting = new string[32];

            // update the data
            NewSetting[0] = Parser.SaveToken("hlam", HLAMPath);
            NewSetting[1] = Parser.SaveToken("mdldec", MDLDecPath);
            NewSetting[2] = Parser.SaveToken("studiomdl", StudioMDLPath);
            NewSetting[3] = Parser.SaveToken("wadmaker", WadmakerPath);
            NewSetting[4] = Parser.SaveToken("spritemaker", SpritemakerPath);
            NewSetting[5] = Parser.SaveToken("outputfolder", modelOutput);

            // overwrite setting
            File.WriteAllLines(Path.Combine(Environment.CurrentDirectory, "bin/config.txt"), NewSetting);

        }
    }
}
