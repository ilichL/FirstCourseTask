using FirstCourseTask.Domain;

public class Calculator : ICalculator
{
    public double? Calculate(double firstNumber, double secondNumber, string operation)
    {
        switch (operation)
        {
            case "1":
                return firstNumber + secondNumber;
            case "2":
                return firstNumber - secondNumber;
            case "3":
                return firstNumber * secondNumber;
            case "4":
                if (secondNumber == 0)
                {
                    return null;
                }
                return firstNumber / secondNumber;
            default:
                return null;
        }
    }
}