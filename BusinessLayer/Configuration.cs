using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Configuration
    {
        public string[] PatternNames { get; set; }

        public Configuration()
        {
            PatternNames = ConfigurationManager.AppSettings["PatternNames"].Split('#');
        }
    }
}
