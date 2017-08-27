using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Configuration
    {
        public string[] PatternNames { get { return ConfigurationManager.AppSettings["PatternNames"].Split(Separator); } }
        public char Separator { get => ConfigurationManager.AppSettings["Separator"].ToCharArray().First(); }
        public string AssemblyName { get => ConfigurationManager.AppSettings["Assembly"]; }
        public string Name { get => ConfigurationManager.AppSettings["Name"]; }
        public string PatternName { get; set; }
        public string FullName { get { return $"{AssemblyName}{PatternName}{Name}"; } }
    }
}
