using System;

namespace CSharp.Capitulo01.ValeTransporte
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Console.Write("Funcionário: ");
            var nome = Console.ReadLine();

            Console.Write("Salário: ");
            var salario = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Gasto com Transporte: ");
            var gastoComTransporte = Convert.ToDecimal(Console.ReadLine());

            var descontoMaximo = salario * 6 / 100;

            var descontoVT = gastoComTransporte > descontoMaximo ? descontoMaximo : gastoComTransporte;
            Console.WriteLine("");
            // Essa letra :c e para modeda current moeda.
            var resultado = $"Funcionário: {nome}\n" +
                $"Salário: {salario:c}\n" +
                $"Desconto VT: {descontoVT:c}\n";

            Console.WriteLine(resultado);

            Console.WriteLine("");

            Console.WriteLine("Pressione Enter para novo cálculo ou Esc para sair.");
            Console.WriteLine("");
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
