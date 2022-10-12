using System;

namespace CSharp.Capitulo02.ValeTransporte
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Funcionario:");
            var nome = Console.ReadLine();

            Console.Write("Salario:");
            var salario = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Gasto com Transporte:");
            var GastoComTransporte = Convert.ToDecimal(Console.ReadLine());

            var descontoMaximo = salario * 6 / 100;

            var descontoVT = GastoComTransporte > descontoMaximo ? descontoMaximo : GastoComTransporte;

            var resultado = $"Funcionario: {nome}\n" +
                $"Salario: {salario:c}\n" +
                $"Desconto VT: {descontoVT:c}";

            Console.WriteLine(resultado);

            Console.WriteLine("Pressione Enter para novo calculo ou Esc para sair.");

            var comando = Console.ReadKey();

            if (comando.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }

            Console.Clear();

            goto Inicio;
        }
    }
}
