using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas_digital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___________Microondas___________");
            Console.WriteLine("_______Potencia maxima 10 !_____");
            Console.WriteLine("_______Tempo Maximo 2min !______");
            Console.WriteLine("________________________________");
            Console.WriteLine("_____Modo Manual press M________");
            Console.WriteLine();

            Console.WriteLine("_________Personalizados_________");
            Console.WriteLine("__Pipoca = p ");
            Console.WriteLine("Carne de Boi = boi");
            Console.WriteLine("Leite = lei");
            Console.WriteLine("Frango = fra");
            Console.WriteLine("Feijão = fei");

            Console.WriteLine("_Pressione s para Aquecer Prato_ ");
            Console.WriteLine("______________+30S______________");
            Console.WriteLine("");
            String LeituraUsuraio = Console.ReadLine();


            if (LeituraUsuraio == "s") // Incio Rapido de 30 segundos !
            {
                Console.WriteLine("Tempo: 30S ");
                Console.WriteLine("Potencia 10!");
                InicioRapido(LeituraUsuraio);
                Console.WriteLine("\nBIP BIP BIP ");

            }
            else if (LeituraUsuraio == "M") // Modo Manual de seleção dos minutos e potencia
            {
                Console.WriteLine("Informe o Tempo :");
                int tempo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe a Potencia :");
                int? potencia = null;

                potencia = Convert.ToInt32(Console.ReadLine());

                if (potencia == null ^ potencia == 0)
                {
                    if (tempo > 60)
                    {
                        int minutos = tempo / 60; // Obter os minutos inteiros
                        int segundos = tempo % 60;
                        string resultado = $"{minutos},{segundos:D2}";

                        potencia = 10;
                        Console.WriteLine("Incio___");
                        Console.WriteLine("Potencia " + potencia);
                        Console.WriteLine("Tempo: " + tempo + segundos);


                        Manual(tempo, potencia);

                        Console.WriteLine("\nBIP BIP BIP ");

                        Console.WriteLine();
                        Console.ReadLine();
                    }
                    else
                    {
                        int minutos = tempo / 60; // Obter os minutos inteiros
                        int segundos = tempo % 60;
                        string resultado = $"{minutos},{segundos:D2}";

                        Console.WriteLine("Incio___");
                        Console.WriteLine("Potencia " + potencia);
                        Console.WriteLine("Tempo: " + tempo);


                        Manual(tempo, potencia);

                        Console.WriteLine("\nBIP BIP BIP ");

                        Console.WriteLine();
                        Console.ReadLine();
                    }
                }
                else if (potencia > 0 && potencia < 11)
                {
                    if (tempo > 60)
                    {
                        int minutos = tempo / 60; // Obter os minutos inteiros
                        int segundos = tempo % 60;
                        string resultado = $"{minutos},{segundos:D2}";

                        Console.WriteLine("Incio___");
                        Console.WriteLine("Potencia " + potencia);
                        Console.WriteLine("Tempo: " + resultado);


                        Manual(tempo, potencia);

                        Console.WriteLine("\nBIP BIP BIP ");

                        Console.WriteLine();
                        Console.ReadLine();
                    }
                    else if ((tempo < 60))
                    {
                        int minutos = tempo / 60; // Obter os minutos inteiros
                        int segundos = tempo % 60;
                        string resultado = $"{minutos},{segundos:D2}";

                        Console.WriteLine("Incio___");
                        Console.WriteLine("Potencia " + potencia);
                        Console.WriteLine("Tempo: " + tempo);


                        Manual(tempo, potencia);

                        Console.WriteLine("\nBIP BIP BIP ");

                        Console.WriteLine();
                        Console.ReadLine();
                    }
                }
                else if (potencia >= 11)
                {
                    Console.WriteLine("Informe uma potencia valida !");
                    Console.WriteLine("Entre 1 e 10");
                }




            }
            else if (LeituraUsuraio == "p") //Modelo pronto da Pipoca
            {
                Pipoca(LeituraUsuraio);
                Console.WriteLine("\nBIP BIP BIP");
                Console.ReadLine();
            }
            else if (LeituraUsuraio == "boi")
            {
                CarneDeBoi(LeituraUsuraio);
                Console.WriteLine("\nBIP BIP BIP");
                Console.ReadLine();
            }
            else if (LeituraUsuraio == "lei")
            {
                Leite(LeituraUsuraio);
                Console.WriteLine("\nBIP BIP BIP");
                Console.ReadLine();
            }
            else if (LeituraUsuraio == "fra")
            {
                Frango(LeituraUsuraio);
                Console.WriteLine("\nBIP BIP BIP");
                Console.ReadLine();
            }
            else if (LeituraUsuraio == "fei")
            {
                Feijao(LeituraUsuraio);
                Console.WriteLine("\nBIP BIP BIP");
                Console.ReadLine();
            }


        }


        static void InicioRapido(string inicio)//Cria os parametros de tempo e potencia pré - definidos

        {
            for (int i = 1; i <= 30; i++)
            {
                Console.Write(" * ");
                System.Threading.Thread.Sleep(100);
            }
        }

        static void CarneDeBoi(string LeituraUsuraio)
        {
            Console.WriteLine("Nome : Carne de Boi");
            Console.WriteLine("Alimento: Leite");
            Console.WriteLine("Potencia: 4");
            Console.WriteLine("Tempo 14 minutos");
            Console.WriteLine("Instruções: Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.");

            for (int i = 1; i <= 840; i++)
            {
                Console.Write(" * ");
                System.Threading.Thread.Sleep(100);
            }
        }

        static void Pipoca(string LeituraUsuraio)
        {
            Console.WriteLine("Nome : Pipoca");
            Console.WriteLine("Alimento: Leite");
            Console.WriteLine("Potencia: 7");
            Console.WriteLine("Tempo 3 minutos");
            Console.WriteLine("Observar o barulho de estouros do milho, caso houver um intervalo de mais de 10 segundos entre um estouro e outro, interrompa o aquecimento.");
            for (int i = 1; i <= 180; i++)
            {
                Console.Write(" * ");
                System.Threading.Thread.Sleep(100);
            }
        }
        static void Leite(string LeituraUsuraio)
        {
            Console.WriteLine("Nome : Leite");
            Console.WriteLine("Alimento: Leite");
            Console.WriteLine("Potencia: 5");
            Console.WriteLine("Tempo 5 minutos");
            Console.WriteLine("Instruções: Cuidado com aquecimento de líquidos, o choque térmico aliado ao movimento do recipiente pode causar fervura imediata causando risco de queimaduras.");
            for (int i = 1; i <= 300; i++)
            {
                Console.Write(" * ");
                System.Threading.Thread.Sleep(100);
            }
        }

        static void Frango(string LeituraUsuraio)
        {
            Console.WriteLine("Nome : Frango");
            Console.WriteLine("Alimento: Frango");
            Console.WriteLine("Potencia: 7");
            Console.WriteLine("Tempo 8 minutos");
            Console.WriteLine("Instruções: Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o descongelamento uniforme.");
            for (int i = 1; i <= 480; i++)
            {
                Console.Write(" * ");
                System.Threading.Thread.Sleep(100);
            }
        }

        static void Feijao(string LeituraUsuraio)
        {
            Console.WriteLine("Nome : Feijao");
            Console.WriteLine("Alimento: Feijao");
            Console.WriteLine("Potencia: 9");
            Console.WriteLine("Tempo 8 minutos");
            Console.WriteLine("Instruções: Deixe o recipiente destampado e em casos de plástico, cuidado ao retirar o recipiente pois o mesmo pode perder resistência em altas temperaturas.");
            for (int i = 1; i <= 480; i++)
            {
                Console.Write(" * ");
                System.Threading.Thread.Sleep(100);
            }
        }






        static void Manual(int Tempo, int? potencia)
        {

            for (int i = 1; i <= Tempo; i++)
            {
                Console.Write(" * ");
                System.Threading.Thread.Sleep(100);
            }
        }



    }



}
