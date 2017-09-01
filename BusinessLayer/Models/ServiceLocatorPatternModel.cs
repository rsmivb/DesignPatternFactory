using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Factory;

namespace BusinessLayer.Models
{
    public class ServiceLocatorPatternModel : IPattern
    {
        public ServiceLocatorPatternModel()
        {

        }

        public string PatternFileName { get; private set; }

        public void GeneratePattern()
        {
            //ServiceLocatorPatternTemplate p = new ServiceLocatorPatternTemplate();
            // Generate text transformed
            //Console.WriteLine(p.TransformText());
        }

        public void SetPatternNameFile(string fileName)
        {
            PatternFileName = fileName;
        }
    }
}
