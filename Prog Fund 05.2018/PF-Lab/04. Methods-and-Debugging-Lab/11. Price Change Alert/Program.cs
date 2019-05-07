using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double firstPrice = double.Parse(Console.ReadLine());
        double previousPrice = firstPrice;

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());

            double priceChange = CalcPriceChange(previousPrice, currentPrice);
            bool isSignificantDifference = HasSignificantChange(priceChange, threshold);

            string message = GetAlert(currentPrice, previousPrice, priceChange, isSignificantDifference);
            Console.WriteLine(message);

            previousPrice = currentPrice;
        }
    }

    private static string GetAlert(double currentPrice, double previousPrice, double priceChange, bool isSignificantDifference)
    {
        string message = "";
        if (priceChange == 0)
        {
            message = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isSignificantDifference)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, priceChange*100);
        }
        else if (isSignificantDifference && (priceChange > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, priceChange*100);
        }
        else if (isSignificantDifference && (priceChange < 0))
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, priceChange*100);
        return message;
    }
    private static bool HasSignificantChange(double priceChange, double threshold)
    {
        if (Math.Abs(priceChange) >= threshold)
        {
            return true;
        }
        return false;
    }

    private static double CalcPriceChange(double priviousPrice, double currentPrice)
    {
        double change = (currentPrice - priviousPrice) / priviousPrice;
        return change;
    }
}
