using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Factory;

namespace BusinessLayer.Models
{
    public class SingletonPatternModel : IPattern
    {
        public SingletonPatternModel()
        {

        }
        public void GeneratePattern()
        {
            //SingletonPatternTemplate p = new SingletonPatternTemplate();
            // Generate text transformed
            //Console.WriteLine(p.TransformText());
        }
    }
}
