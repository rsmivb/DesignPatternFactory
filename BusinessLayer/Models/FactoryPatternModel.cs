using BusinessLayer.PatternTemplates;
using System;
using BusinessLayer.Factory;

namespace BusinessLayer.Models
{
    internal class FactoryPatternModel : IPattern
    {
        public FactoryPatternModel()
        {
        }

        public void GeneratePattern()
        {
            FactoryPatternTemplate p = new FactoryPatternTemplate();
            // Generate text transformed
            Console.WriteLine(p.TransformText());
        }
    }
}