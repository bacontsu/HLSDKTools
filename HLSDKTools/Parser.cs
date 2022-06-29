using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLSDKTools
{
    public partial class Parser
    {
        // ===================================================================================
        // ExtractToken - Extract settings from the config file
        // ===================================================================================
        public static string ExtractToken(string token, string[] fileContent)
        {
            if (!string.IsNullOrEmpty(token) && fileContent != null)
            {
                foreach (string line in fileContent)
                {
                    if (line.StartsWith(token))
                    {
                        return line.Remove(0, token.Length + 1);
                    }
                    else continue;
                }
                return null;
            }
            else
            return null;
        }

        // ===================================================================================
        // SaveToken - Save settings from the config file
        // ===================================================================================
        public static string SaveToken(string token, string path)
        {
            if (!string.IsNullOrEmpty(token))
            {
                return token + " " + path;
            }
            else
                return null;
        }

    }
}
