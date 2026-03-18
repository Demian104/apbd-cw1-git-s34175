namespace ConsoleApp1;

public static class StatisticsHelper
{
    public static double Mean(IEnumerable<double> data)
    {
        if (data == null || !data.Any())
            throw new ArgumentException("Коллекция пуста");

        return data.Average();
    }
    
}