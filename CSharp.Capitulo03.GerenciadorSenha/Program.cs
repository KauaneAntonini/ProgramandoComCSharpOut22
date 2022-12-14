using System;

namespace CSharp.Capitulo03.GerenciadorSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Informe a quantidade de dígitos da senha (entre 4 e 10, pares):");
            //var quantidadeDigitos = Convert.ToInt32(Console.ReadLine());

            //var quantidadeDigitos = 0;

          /*  while (quantidadeDigitos == 0)
            {
                //quantidadeDigitos = ObterQuantidadeDigitos();
            }
          */
            int quantidadeDigitos;

            do
            {
                Console.Write("Informe a quantidade de dígitos da senha (entre 4 e 10, pares):");
                quantidadeDigitos = ObterQuantidadeDigitos();
            } while (quantidadeDigitos == 0);

            //if (quantidadeDigitos < 4 || quantidadeDigitos > 10 || quantidadeDigitos % 2 != 0)
            /*
            if (quantidadeDigitos is <4 or > 10 || quantidadeDigitos % 2 != 0)
            {
                Console.WriteLine($"O valor {quantidadeDigitos} é inválido de acordo com as regras");
                Console.ReadKey();
                return;         
            }
            */

            var senha = "";
            var randomico = new Random();

            for (int i = 0; i < quantidadeDigitos; i++)
            {
                var algarismo = randomico.Next(0,10);
                //var algarismo = randomico.Next(10);

                senha += algarismo;       
            }

            Console.WriteLine($"Senha gerada: {senha}");
        }

        private static int ObterQuantidadeDigitos()
        {
            int.TryParse(Console.ReadLine(), out int quantidadeDigitos);

            if (quantidadeDigitos is < 4 or > 10 || quantidadeDigitos % 2 != 0)
            {
                Console.WriteLine($"O valor {quantidadeDigitos} é inválido de acordo com as regras");
                quantidadeDigitos = 0;
            }
            return quantidadeDigitos;
        }
    }
}
