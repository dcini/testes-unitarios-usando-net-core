using NewTalents;

namespace TesteNewTalents;

public class UnitTest1
{
    
    
    public Calculadora Construir()
    {
        string data = "11/09/2024";
        Calculadora calc = new Calculadora(data);
        return calc;
    }

    [Theory]
    [InlineData(1,2,3)]
    [InlineData(4,2,6)]
    [InlineData(9,15,24)]
    public void TesteSomar(int val1, int val2, int resultado)
    {
        // Arrange
        Calculadora calc = Construir();
        // Act
        int resultadoCalculadora = calc.Soma(val1,val2);
        // Asset
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(9,3,6)]
    [InlineData(4,2,2)]
    [InlineData(8,8,0)]
    public void TesteSubtrair(int val1, int val2, int resultado)
    {
        // Arrange
        Calculadora calc = Construir();
        // Act
        int resultadoCalculadora = calc.Subtrair(val1,val2);
        // Asset
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(9,3,27)]
    [InlineData(4,2,8)]
    [InlineData(8,8,64)]
    public void TesteMultiplicar(int val1, int val2, int resultado)
    {
        // Arrange
        Calculadora calc = Construir();
        // Act
        int resultadoCalculadora = calc.Multiplicar(val1,val2);
        // Asset
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(9,3,3)]
    [InlineData(4,2,2)]
    [InlineData(8,8,1)]
    public void TesteDividir(int val1, int val2, int resultado)
    {
        // Arrange
        Calculadora calc = Construir();
        // Act
        int resultadoCalculadora = calc.Dividir(val1,val2);
        // Asset
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TesteDividirPorZero()
    {
        // Arrange
        Calculadora calc = Construir();
        // Act
         // Asset
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3,0));
    }

    [Fact]
    public void TestarHistorico()
    {
        // Arrange
        Calculadora calc = Construir();
        
        // Act
        calc.Soma(1,2);
        calc.Soma(1,3);
        calc.Subtrair(10,2);
        calc.Multiplicar(1,2);
         // Asset
        List<string> lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3,lista.Count());
    }
}