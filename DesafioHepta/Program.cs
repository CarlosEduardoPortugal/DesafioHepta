using DesafioHepta;

var numbers = new List<string>
{
    "00100", "11110", "10110", "10111", "10101", 
    "01111", "00111", "11100", "10000", "11001", 
    "00010", "01010"
};

var submarine = new Submarine();
Console.WriteLine(submarine.Energy(numbers));