namespace DesafioHepta;

public class GamaCalculationStrategy : ISubmarineCalculatorStrategy
{
    public string EnergyConsumer(List<string> numbers)
    {
        var result = "";
        var bitLength = numbers[0].Length;

        for (int i = 0; i < bitLength; i++)
        {
            var ones = numbers.Count(num => num[i] == '1');
            var zeros = numbers.Count - ones;

            result += ones >= zeros ? "1" : "0";
        }

        return result;
    }
}