namespace DesafioHepta;

public class Submarine : ISubmarine
{
    private readonly EnergyGamaCalculation _energyGamaCalculator;
    private readonly EnergyEpsilonCalculation _energyEpsilonCalculator;

    public Submarine()
    {
        _energyGamaCalculator = new EnergyGamaCalculation();
        _energyEpsilonCalculator = new EnergyEpsilonCalculation();
    }

    public int Energy(List<string> numbers)
    {
        var gamaNumber = _energyGamaCalculator.Calculate(numbers);
        var epilsonNumber = _energyEpsilonCalculator.Calculate(numbers);

        return Convert.ToInt32(gamaNumber, 2) * Convert.ToInt32(epilsonNumber, 2);
    }
}