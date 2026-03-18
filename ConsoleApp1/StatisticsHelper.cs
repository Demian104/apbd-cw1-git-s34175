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
    public static double Variance(IEnumerable<double> data)
    {
        if (data == null || !data.Any())
            throw new ArgumentException("Коллекция пуста");

        double mean = Mean(data);
        return data.Select(x => Math.Pow(x - mean, 2)).Average();
    }

    
}