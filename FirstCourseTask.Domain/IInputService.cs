namespace FirstCourseTask.Domain
{
    public interface IInputService
    {
        double GetValidNumber(string prompt);
        string GetValidOperation();
        bool ShouldContinue();
    }
}