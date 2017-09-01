namespace BusinessLayer.Factory
{
    public interface IPattern
    {
        string PatternFileName { get; }
        void GeneratePattern();
        void SetPatternNameFile(string fileName);
    }
}