﻿using BusinessLayer.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class BridgePatternModel : IPattern
    {
        public BridgePatternModel()
        {

        }

        public string PatternFileName { get; private set; }

        public void GeneratePattern()
        {
            //BridgePatternTemplate p = new BridgePatternTemplate();
            // Generate text transformed
            //Console.WriteLine(p.TransformText());
        }

        public void SetPatternNameFile(string fileName)
        {
            PatternFileName = fileName;
        }
    }
}
