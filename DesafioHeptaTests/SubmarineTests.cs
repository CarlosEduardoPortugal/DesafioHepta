using DesafioHepta;

namespace DesafioHeptaTests;

public class SubmarineTests
{
    [Fact]
    public void Submarine_DeveRetornarEnergiaCorreto()
    {
        var numerosBinarios = new List<string>
        {
            "00100", "11110", "10110", "10111", "10101", 
            "01111", "00111", "11100", "10000", "11001", 
            "00010", "01010"
        };
        var calculator = new Submarine();

        var resultado = calculator.Energy(numerosBinarios);

        Assert.Equal(198, resultado);
    }

    [Fact]
    public void BitCalculator_ComListaVazia_DeveLancarExcecao()
    {
        var numerosBinarios = new List<string>();
        var calculator = new Submarine();

        Assert.Throws<ArgumentException>(() => calculator.Energy(numerosBinarios));
    }
}