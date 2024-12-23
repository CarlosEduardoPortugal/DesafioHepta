namespace DesafioHepta;

public class Submarine : ISubmarine
{
    private readonly GamaCalculationStrategy _gamaCalculator;
    private readonly EpsilonCalculationStrategy _epsilonCalculator;

    public Submarine()
    {
        _gamaCalculator = new GamaCalculationStrategy();
        _epsilonCalculator = new EpsilonCalculationStrategy();
    }

    public int Energy(List<string> numbers)
    {
        var gamaNumber = _gamaCalculator.EnergyConsumer(numbers);
        var epilsonNumber = _epsilonCalculator.EnergyConsumer(numbers);

        return Convert.ToInt32(gamaNumber, 2) * Convert.ToInt32(epilsonNumber, 2);
    }
}