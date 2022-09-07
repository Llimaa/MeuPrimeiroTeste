namespace MeuPrimeiroTeste;
public class Calculadora
{
    public decimal Somar(decimal valor1, decimal valor2)
    {
        return valor1 + valor2;
    }

    public decimal Subtrair(decimal valor1, decimal valor2)
    {
        return valor1 - valor2;
    }

    public decimal Multiplicar(decimal valor1, decimal valor2)
    {
        return valor1 * valor2;
    }

    public decimal Dividir(decimal valor1, decimal valor2)
    {
        if (valor2 == 0)
            throw new Exception("Não pode dividir por zero");
        return valor1 / valor2;
    }
}