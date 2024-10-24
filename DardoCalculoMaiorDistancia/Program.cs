//Problema "dardo"
//No arremesso de dardo, o atleta tem três chances para lançar o dardo à maior distância que conseguir.
//Você deve criar um programa para, dadas as medidas das três tentativas de lançamento, informar qual
//foi a maior. 

using System.Globalization;

namespace DardoCalculoMaiorDistancia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distancia1, distancia2, distancia3, maiorDistancia;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite as tres distancias: ");
            distancia1 = double.Parse(Console.ReadLine(), CI);
            distancia2 = double.Parse(Console.ReadLine(), CI);
            distancia3 = double.Parse(Console.ReadLine(), CI);

            if (distancia1 >= distancia2 && distancia1 >= distancia3)
            {
                maiorDistancia = distancia1;
            }
            else if (distancia2 >= distancia3)
            {
                maiorDistancia = distancia2;
            }
            else
            {
                maiorDistancia = distancia3;
            }

            Console.WriteLine($"MAIOR DISTANCIA = {maiorDistancia.ToString("F2", CI)}");
        }
    }
}
