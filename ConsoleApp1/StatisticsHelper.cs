namespace ConsoleApp1;

public static class StatisticsHelper
{
    public static double Mean(IEnumerable<double> data)
    {
        if (data == null || !data.Any())
            throw new ArgumentException("Коллекция пуста");

        return data.Average();
    }
    public static double Median(IEnumerable<double> data)
    {
        if (data == null || !data.Any())
            throw new ArgumentException("Коллекция пуста");

        var sorted = data.OrderBy(x => x).ToList();
        int count = sorted.Count;

        if (count % 2 == 0)
            return (sorted[count / 2 - 1] + sorted[count / 2]) / 2.0;

        return sorted[count / 2];
    }
}