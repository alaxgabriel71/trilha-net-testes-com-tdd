using Calculadora.Models;
namespace CalculadoraTest;

public class CalculadoraTest
{
    private Calc _calc = new();
    
    [Fact]
    public void TestarSoma()
    {
        //Arrange
        //Act
        var resultado = _calc.Somar(2, 3);
        //Assert
        Assert.Equal(5, resultado);
    }
    [Fact]
    public void TestarSubtracao()
    {
        //Arrange
        //Act
        var resultado = _calc.Subtrair(3, 2);
        //Assert
        Assert.Equal(1, resultado);
    }
    [Fact]
    public void TestarMultiplicacao()
    {
        //Arrange
        //Act
        var resultado = _calc.Multiplicar(3, 2);
        //Assert
        Assert.Equal(6, resultado);
    }
    [Fact]
    public void TestarDivisao()
    {
        //Arrange
        //Act
        var resultado = _calc.Dividir(3, 1);
        //Assert
        Assert.Equal(3, resultado);
    }
    [Fact]
    public void TestarDivisaoPorZero()
    {
        //Arrange
        //Act
        //Assert
        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(3, 0));
    }
    [Fact]
    public void TestarHistorico()
    {
        //Arrange
        _calc.Somar(2, 3);
        _calc.Somar(2, 3);
        _calc.Somar(2, 3);
        //Act
        var resultado = _calc.Historico();
        //Assert
        Assert.Equal(3, resultado.Count);
    }
}