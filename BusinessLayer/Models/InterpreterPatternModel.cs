using BusinessLayer.Factory;

namespace BusinessLayer.Models
{
    public class InterpreterPatternModel : IPattern
    {
        public InterpreterPatternModel()
        {

        }

        public string PatternFileName { get; private set; }

        public void GeneratePattern()
        {
            //InterpreterPatternTemplate p = new InterpreterPatternTemplate();
            // Generate text transformed
            //Console.WriteLine(p.TransformText());
        }

        public void SetPatternNameFile(string fileName)
        {
            PatternFileName = fileName;
        }
    }
}