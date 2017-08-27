namespace BusinessLayer.Factory
{
    public interface IPatternFactory
    {
        IPattern CreatePattern(string name);
    }
}