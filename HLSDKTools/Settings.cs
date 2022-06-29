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

        }    
    }
}
