using Interfaces.Entidades;
using Interfaces.Serviços;
using System;
using System.Globalization;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel:");
            Console.Write("Modelo veiculo: ");
            string modelo = Console.ReadLine();

            Console.Write("Entrada (dd/MM/yyyy hh:mm): ");
            DateTime dataEntrada = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm" , CultureInfo.InvariantCulture);

            Console.Write("Retorno (dd/MM/yyyy hh:mm): ");
            DateTime dataRetorno = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Entre com o valor da hora: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com o valor da diaria: ");
            double valorDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            AluguelCarro aluguelcarro = new AluguelCarro(dataEntrada, dataRetorno, new Veiculo(modelo));

            ServicoAluguel servicoAluguel = new ServicoAluguel(valorHora, valorDia);

            servicoAluguel.ProcessoPagamento(aluguelcarro);

            Console.WriteLine("Pagamento");
            Console.WriteLine(aluguelcarro.Pagamento);

            
        }
    }
}
