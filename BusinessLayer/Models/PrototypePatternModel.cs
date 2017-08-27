using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Factory;

namespace BusinessLayer.Models
{
    public class PrototypePatternModel : IPattern
    {
        public PrototypePatternModel()
        {

        }
        public void GeneratePattern()
        {
            //PrototypePatternTemplate p = new PrototypePatternTemplate();
            // Generate text transformed
            //Console.WriteLine(p.TransformText());
        }
    }
}
