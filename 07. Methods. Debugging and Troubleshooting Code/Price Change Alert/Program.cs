using System;

class PriceChangeAlert
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        double threshold = double.Parse(Console.ReadLine());

        double last = double.Parse(Console.ReadLine());

        for (int i = 0; i < number - 1; i++)
        {
            double price = double.Parse(Console.ReadLine());
            double difference = Proc(last, price); bool isSignificantDifference = imaliDif(difference, threshold);



            string message = Get(price, last, difference, isSignificantDifference);
            Console.WriteLine(message);

            last = price;
        }
    }

    private static string Get(double price, double last, double diff, bool etherTrueOrFalse)
    {
        string to = string.Empty;
        if (diff == 0)
        {
            to = string.Format("NO CHANGE: {0}", price);
        }
        else if (!etherTrueOrFalse)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, price, diff * 100);
        }
        else if (etherTrueOrFalse && (diff > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, price, diff * 100);
        }
        else if (etherTrueOrFalse && (diff < 0))
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, price, diff * 100);
        return to;
    }
    private static bool imaliDif(double threshold, double isDiff)
    {
        if (Math.Abs(threshold) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double Proc(double l, double price)
    {
        double r = (price - l) / l;
        return r;
    }
}
