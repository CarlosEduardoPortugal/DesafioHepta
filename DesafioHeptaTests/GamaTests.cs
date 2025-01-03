using DesafioHepta;

namespace DesafioHeptaTests;

public class GamaTests
{
    [Fact]
    public void Gama_DeveRetornarGamaCorreto()
    {
        var numerosBinarios = new List<string>
        {
            "00100", "11110", "10110", "10111", "10101", 
            "01111", "00111", "11100", "10000", "11001", 
            "00010", "01010"
        };
        var strategy = new EnergyGamaCalculation();

        string resultado = strategy.Calculate(numerosBinarios);

        Assert.Equal("10110", resultado);
    }

    [Fact]
    public void Gama_ComListaVazia_DeveLancarExcecao()
    {
        var numerosBinarios = new List<string>();
        var strategy = new EnergyGamaCalculation();

        Assert.Throws<ArgumentOutOfRangeException>(() => strategy.Calculate(numerosBinarios));
    }
}