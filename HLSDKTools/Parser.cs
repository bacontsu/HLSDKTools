using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLSDKTools
{
    public class Parser
    {
        public static string ExtractToken(string token, string[] fileContent)
        {
            if (!string.IsNullOrEmpty(token) && fileContent != null)
            {
                foreach (string line in fileContent)
                {
                    if (line.StartsWith(token))
                    {
                        string processed1 = line.Replace(token, "");
                        processed1 = processed1.Replace('"', ' ');
                        processed1 = processed1.Replace(" ", "");
                        processed1 = processed1.Replace("%20", " ");

                        return processed1;
                    }
                    else return null;
                }
                return null;

            }
            else
            return null;
        }

    }
}
