using BusinessLayer.PatternTemplates;
using System;
using BusinessLayer.Factory;
using BusinessLayer.Utils;

namespace BusinessLayer.Models
{
    internal class FactoryPatternModel : IPattern
    {
        public FactoryPatternModel()
        {
        }

        public string PatternFileName { get; private set; }

        public void GeneratePattern()
        {
            FactoryPatternTemplate p = new FactoryPatternTemplate();
            // Generate text transformed
            FileHandler.CreateFile(PatternFileName, p.TransformText());
        }

        public void SetPatternNameFile(string fileName)
        {
            PatternFileName = fileName;
        }
    }
}