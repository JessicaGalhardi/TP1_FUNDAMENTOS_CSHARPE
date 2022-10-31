
using Biblioteca;


namespace BoasVindas

{
    public class Saudacao
    {
        static void Main(string[] args)
        {
            //Recebendo a identificação do usuário
            string nome;

            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Olá, " + nome + ". Seja bem-vinda(o)! Essa solução calcula a soma, subtração, multiplicação e divisão de dois números." + "\r\n");
            Console.ReadKey();

            //_________________________________________________________________________________________________________________________________________________________________
            //Instanciando as classes de cálculo

            Divisao objetoDivisao = new Divisao();
            objetoDivisao.CalcularDivisao();

            Soma objetoSoma = new Soma();
            objetoSoma.Calcularsoma();

            Subtracao objetoSubtracao = new Subtracao();
            objetoSubtracao.CalcularSubtracao();

            Multiplicacao objetoMultiplicacao = new Multiplicacao();
            objetoMultiplicacao.CalcularMultiplicacao();


        }

    }

}
