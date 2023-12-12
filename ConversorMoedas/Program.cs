using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao Conversor de Moedas!");

        Console.Write("Digite o valor em reais: ");
        double valorEmReais = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a taxa de câmbio para iene (por exemplo, 0.034 para 1 real): ");
        double taxaDeCambioParaIene = Convert.ToDouble(Console.ReadLine());

        double valorConvertidoParaIene = valorEmReais * taxaDeCambioParaIene;

        Console.WriteLine($"O valor convertido é: ¥{valorConvertidoParaIene:N2}");

        Console.WriteLine("\nPressione Enter para fechar o programa.");
        Console.ReadLine();
    }
}
