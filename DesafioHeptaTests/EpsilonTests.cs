using DesafioHepta;

namespace DesafioHeptaTests;

public class EpsilonTests
{
    [Fact]
    public void Epsilon_DeveRetornarEpsilonCorreto()
    {
        var numerosBinarios = new List<string>
        {
            "00100", "11110", "10110", "10111", "10101", 
            "01111", "00111", "11100", "10000", "11001", 
            "00010", "01010"
        };
        var strategy = new EnergyEpsilonCalculation();

        string resultado = strategy.Calculate(numerosBinarios);

        Assert.Equal("01001", resultado);
    }

    [Fact]
    public void Epsilon_ComListaVazia_DeveLancarExcecao()
    {
        var numerosBinarios = new List<string>();
        var strategy = new EnergyEpsilonCalculation();

        Assert.Throws<ArgumentOutOfRangeException>(() => strategy.Calculate(numerosBinarios));
    }
}