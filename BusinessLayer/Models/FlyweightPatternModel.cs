using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Factory;

namespace BusinessLayer.Models
{
    public class FlyweightPatternModel : IPattern
    {
        public FlyweightPatternModel()
        {

        }
        public void GeneratePattern()
        {
            //FlyweightPatternTemplate p = new FlyweightPatternTemplate();
            // Generate text transformed
            //Console.WriteLine(p.TransformText());
        }
    }
}
