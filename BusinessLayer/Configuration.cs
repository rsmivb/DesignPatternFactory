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
        public string[] PatternNames { get { return BusinessLayer.Properties.Resources.PatternNames.Split(Separator); } }
        private char Separator { get => BusinessLayer.Properties.Resources.Separator.ToCharArray().First(); }
        private string AssemblyName { get => BusinessLayer.Properties.Resources.Assembly; }
        private string Name { get => BusinessLayer.Properties.Resources.Name; }

    }
}
