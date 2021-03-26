using System;

namespace Projetil
{
    class Program
    {
        static void Main(string[] args)
        {
            string medida1, medida2;
            double Almax,Alcance, V, A,angrad;
            const double gravidade= 9.80665;

            Console.Beep();
            Console.WriteLine();
            Console.WriteLine("--Projétil--");
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.Write("Digite a velocidade do projétil (em m/s):");
            medida1 = Console.ReadLine();
            Console.Write("Digite o ângulo (em graus):");
            medida2 = Console.ReadLine();

            V= Convert.ToDouble(medida1);
            A= Convert.ToDouble(medida2);
            angrad= Convert.ToDouble(A*((Math.PI)/180));

            angrad = A *(Math.PI / 180);
            Alcance = Math.Pow(V, 2) * Math.Sin(2 * angrad) / gravidade;
            Almax = Math.Pow((V * Math.Sin(angrad)), 2) / (2 * gravidade);
            

            Console.Beep();
            Console.WriteLine("-----------");
            Console.WriteLine("--Resultados--");
            Console.WriteLine();
            Console.WriteLine($"Altura máxima:{Almax:N2}m");
            Console.WriteLine($"Alcance máximo:{Alcance:N2}m");
            Console.WriteLine("-----------");
        }
    }
}
