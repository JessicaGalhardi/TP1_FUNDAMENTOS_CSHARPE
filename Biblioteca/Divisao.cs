using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Divisao

    {
        public void CalcularDivisao()
        {

            //Recebendo o imput do usuário para o primeiro número

            int valor1;
            int valor2;

            Console.WriteLine("Por favor, digite o primeiro número a ser dividido:");

            string? variavelLeitura1 = Console.ReadLine();

            bool seConverteu = int.TryParse(variavelLeitura1, out valor1);

            if (seConverteu)
            {
                valor1 = Convert.ToInt32(variavelLeitura1);
            }
            else
            {

                valor1 = 0;
            }

            //______________________________________________________________________________________________________________
            //Recebendo o imput do usuário para o segundo número

            Console.WriteLine("Por favor, digite o segundo número a ser dividido:");

            string? variavelLeitura2 = Console.ReadLine();

            bool seConverteu2 = int.TryParse(variavelLeitura2, out valor2);

            if (seConverteu2)
            {
                valor2 = Convert.ToInt32(variavelLeitura2);
            }
            else
            {

                valor2 = 0;
            }

            //______________________________________________________________________________________________________________
            //Realizando a soma dos valores e apresetando o resultado

            Console.WriteLine("O resultado da divisão de " + valor1 + " / " + valor2 + " é: " + (valor1 / valor2) + "\r\n");

            Console.ReadKey();


        }
    }
}
