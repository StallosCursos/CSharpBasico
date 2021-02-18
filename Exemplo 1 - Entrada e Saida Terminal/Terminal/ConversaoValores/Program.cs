using System;

namespace ConversaoValores
{
    /************************************************************************************/
    /***  TIPOS DE DADOS PRIMITIVOS C#                                         **********/
    /************************************************************************************/

    // bool - valor de teste logico valores aceitaveis true ou false
    // char - representação de um char baseado na tabela ASCII

    // Ponto Flutuante
    // float - aceita um numero com ponto flutuante de ate 4bytes
    //   float	±1,5 x 10−45 para ±3,4 x 1038	~6 a 9 dígitos	4 bytes System.Single
    // double - aceita um numero com ponto flutuante de ate 8bytes
    //   double	±5.0 × 10−324 to ±1.7 × 10308	~15 a 17 dígitos	8 bytes	System.Double
    // decimal - aceita um numero com ponto flutuante de ate 16bytes
    //   decimal	±1,0 x 10-28 para ±7,9228 x 1028	28 a 29 dígitos	16 bytes	System.Decimal

    // Inteiros
    // sbyte - aceita numeros inteiros de ate 8bits com sinal -128 a 127
    // byte - aceita numeros inteiros de 8bits sem sinal 0 a 255
    // short - aceita numeros inteiros de 16bits com sinal -32.768 a 32.767
    // ushort - aceita numeros inteiros de 16bits sem sinal 0 a 65.535    
    // int - aceita numeros inteiros de ate 32bits assinado  -2.147.483.648 a 2.147.483.647
    // uint - aceita numeros inteiros de 32bits sem sinal 0 a 4.294.967.295
    // long - aceita numeros inteiros de 64bits assinado -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
    // ulong - aceita numeros inteiros de de 64bits sem sinal 	0 a 18.446.744.073.709.551.615

    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de escrita no terminal
            Console.WriteLine("Digite sua idade em anos!");

            // Recebe a linha e converte para um inteiro
            int Idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite sua data de nascimento no formato DD/MM/YYYY!");

            // Recebe a linha e converte para uma data
            DateTime DataNascimento = Convert.ToDateTime(Console.ReadLine());
        }
    }
}
