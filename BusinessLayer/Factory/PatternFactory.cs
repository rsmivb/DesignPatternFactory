using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Factory
{
    public class PatternFactory : IPatternFactory
    {
        public PatternFactory()
        {

        }
        public IPattern CreatePattern(string name)
        {
            return Assembly.GetExecutingAssembly().CreateInstance(name, true) as IPattern;
        }
    }
}
