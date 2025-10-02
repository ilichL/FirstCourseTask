namespace FirstCourseTask.Domain
{
    public interface ICalculator
    {
        double? Calculate(double firstNumber, double secondNumber, string operation);
    }
}