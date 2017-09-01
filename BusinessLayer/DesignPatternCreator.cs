using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using BusinessLayer.Factory;

namespace BusinessLayer
{
    public class DesignPatternCreator
    {
        private readonly IPatternFactory factory;

        private Configuration config;
        public string PatternName { get; set; }
        public DesignPatternCreator()
        {
            IPatternFactory factory = new PatternFactory();
            config = new Configuration();
        }

        public void Execute()
        {
            IPattern patternCreated = factory.CreatePattern(PatternName);
            patternCreated.SetPatternNameFile($"{PatternName.Replace(" ","")}.cs");
            patternCreated.GeneratePattern();
        }

        public IEnumerable GetPatterns()
        {
            return from p in config.PatternNames
                        select p;
        }
    }
}
