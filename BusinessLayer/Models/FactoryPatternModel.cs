using BusinessLayer.PatternTemplates;
using System;
using BusinessLayer.Factory;
using BusinessLayer.Utils;

namespace BusinessLayer.Models
{
    internal class FactoryPatternModel : IPattern
    {
        public const string PatternName = "FactoryPattern.cs";
        public FactoryPatternModel()
        {
        }

        public void GeneratePattern()
        {
            FactoryPatternTemplate p = new FactoryPatternTemplate();
            // Generate text transformed
            FileHandler.CreateFile(PatternName, p.TransformText());
        }
    }
}