using FluentAssertions;

namespace MeuPrimeiroTeste;

public class CalculadoraTestes
{
    private Calculadora calculadora { get; }
    public CalculadoraTestes()
    {
        calculadora = new();
    }

    [Fact]
    public void Metodo_Somar_Deve_Retornar_Valor_Igual_A_Onze()
    {
        calculadora.Somar(7, 4).Should().Be(11);
    }


    [Fact]
    public void Metodo_Subtrair_Deve_Retornar_Valor_Igual_A_Cinco()
    {

        calculadora.Subtrair(20, 15).Should().Be(5);
    }


    [Fact]
    public void Metodo_Multiplicar_Deve_Retornar_Valor_Igual_A_Cem()
    {
        calculadora.Multiplicar(5, 20).Should().Be(100);
    }


    [Fact]
    public void Metodo_Dividir_Deve_Retornar_Valor_Igual_A_Cinco()
    {
        calculadora.Dividir(10, 2).Should().Be(5);
    }


    [Fact]
    public void Metodo_Dividir_Deve_Retornar_Excecao_Quando_Valor2_Igual_Zero()
    {
        var valor1 = 10;
        var valor2 = 0;
        Assert.Throws<Exception>(() => calculadora.Dividir(valor1, valor2));
    }

    [Fact]
    public void Metodo_Dividir_Deve_Retornar_Excecao_Com_Descricao_Especifica()
    {
        var valor1 = 10;
        var valor2 = 0;
        var exeption = Assert.Throws<Exception>(() => calculadora.Dividir(valor1, valor2));
        exeption.Message.Should().Be("Não pode dividir por zero");
    }
}