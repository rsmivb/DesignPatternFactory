using BusinessLayer.Factory;
using BusinessLayer.PatternTemplates;
using BusinessLayer.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    internal class BuilderPatternModel : IPattern
    {
        public string PatternFileName { get; private set; }
        public BuilderPatternModel()
        {

        }

        public void GeneratePattern()
        {
            BuilderPatternTemplate p = new BuilderPatternTemplate();
            // Generate text transformed
            FileHandler.CreateFile(PatternFileName, p.TransformText());
        }

        public void SetPatternNameFile(string fileName)
        {
            PatternFileName = fileName;
        }
    }
}
