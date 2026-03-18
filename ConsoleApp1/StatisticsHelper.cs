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
    }public static double StandardDeviation(IEnumerable<double> data)
    {
        return Math.Sqrt(Variance(data));
    }

    public static double Min(IEnumerable<double> data)
    {
        if (data == null || !data.Any())
            throw new ArgumentException("Коллекция пуста");

        return data.Min();
    }

    public static double Max(IEnumerable<double> data)
    {
        if (data == null || !data.Any())
            throw new ArgumentException("Коллекция пуста");

        return data.Max();
    }

    public static double Percentile(IEnumerable<double> data, double percentile)
    {
        if (data == null || !data.Any())
            throw new ArgumentException("Коллекция пуста");

        if (percentile < 0 || percentile > 100)
            throw new ArgumentException("Перцентиль должен быть от 0 до 100");

        var sorted = data.OrderBy(x => x).ToList();
        double position = (percentile / 100.0) * (sorted.Count - 1);
        int lower = (int)Math.Floor(position);
        int upper = (int)Math.Ceiling(position);

        if (lower == upper)
            return sorted[lower];

        double weight = position - lower;
        return sorted[lower] * (1 - weight) + sorted[upper] * weight;
    }
    public static double CalculateAverage(int[] values)
    {
        if (values == null || values.Length == 0)
            throw new ArgumentException("Массив пуст или null");

        return values.Average();
    }
    
}