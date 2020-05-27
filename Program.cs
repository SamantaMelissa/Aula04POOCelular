using System;

namespace POO4celular
{
    class Program
    {
        static void Main(string[] args)
        {
            celulares motorola = new celulares();
            motorola.modelo = "Motorola one";
            motorola.cor = "preto";
            motorola.tamanho = 7.1f;
            motorola.ligado = true;


            Console.WriteLine("Deseja um celular ligado?");
            motorola.ligado = motorola.TraduzConsole( Console.ReadLine() );

         Console.WriteLine("Seu celular poderá ligar, deligar, fazer ligação e enviar mensagem.");
         motorola.ligado = motorola.TraduzConsole( Console.ReadLine() );

            




        }
    }
}