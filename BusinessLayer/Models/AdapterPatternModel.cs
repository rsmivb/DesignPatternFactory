﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.PatternTemplates;
using BusinessLayer.Factory;

namespace BusinessLayer.Models
{
    public class AdapterPatternModel : IPattern
    {
        public AdapterPatternModel()
        {

        }

        public string PatternFileName { get; private set; }

        public void GeneratePattern()
        {
            //AdapterPatternTemplate p = new AdapterPatternTemplate();
            // Generate text transformed
            //Console.WriteLine(p.TransformText());
        }

        public void SetPatternNameFile(string fileName)
        {
            PatternFileName = fileName;
        }
    }
}
