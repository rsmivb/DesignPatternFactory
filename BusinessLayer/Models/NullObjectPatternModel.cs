using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Factory;

namespace BusinessLayer.Models
{
    public class NullObjectPatternModel : IPattern
    {
        public NullObjectPatternModel()
        {

        }
        public void GeneratePattern()
        {
            //NullOfObjectPatternTemplate p = new NullOfObjectPatternTemplate();
            // Generate text transformed
            //Console.WriteLine(p.TransformText());
        }
    }
}
