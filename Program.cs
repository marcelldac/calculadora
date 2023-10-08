using System;
namespace Calculator{
    class Program{
        static void Main(string[] args){
            Console.Clear();
            
            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual Operação Deseja escolher?\n1: +\n2: -\n3: /\n4: *\n5: Sair.");
            int op = int.Parse(Console.ReadLine());

            switch(op){
                case 1:
                    Console.WriteLine(Soma(v1,v2));
                    break;
                case 2:
                    Console.WriteLine(Subtracao(v1,v2));
                    break;
                case 3:
                    Console.WriteLine(Divisao(v1,v2));
                    break;
                case 4:
                    Console.WriteLine(Multiplicacao(v1,v2));
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Escolha não encontrada.");
                    break;
            }
        }

        static float Soma(float a, float b){
            return a+b;
        }

        static float Subtracao(float a, float b){
            return a-b;
        }

        static float Divisao(float a, float b){
            return a/b;
        }

        static float Multiplicacao(float a, float b){
            return a*b;
        }

    }
}