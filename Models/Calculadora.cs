namespace Calculadora.Models;
public class Calculadora
{
    public void Somar(int x, int y)
    {
        Console.WriteLine($"{x} + {y} = {x + y}");
    }
    public void Subtrair(int x, int y)
    {
        Console.WriteLine($"{x} - {y} = {x - y}");
    }
    public void Miltiplicar(int x, int y)
    {
        Console.WriteLine($"{x} X {y} = {x * y}");
    }
    public void Dividir(int x, int y)
    {
        Console.WriteLine($"{x} / {y} = {x / y}");
    }
}