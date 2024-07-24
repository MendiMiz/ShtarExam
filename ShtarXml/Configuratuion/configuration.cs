using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShtarXml.Configuratuion
{
    internal static class Configuration
    {
        public static string ShtarPath = Path.Combine(
           Directory.GetCurrentDirectory(),
           "shtar.xml"
           );
    }
}
