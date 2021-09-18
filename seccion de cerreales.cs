using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            float suma = 0;
            string respuesta, cant = "";
            do
            {
                Console.WriteLine("La Seccion de Cereales ofrece lo siguiente:");
                Console.WriteLine("1.-Miel Pops...............10Bs");
                Console.WriteLine("2.-Rellenos de Leche.......10Bs");
                Console.WriteLine("3.-Milo....................10Bs");
                Console.WriteLine("4.-Kelluy..................15Bs");
                Console.WriteLine("5.-Froties.................15Bs");
                Console.WriteLine("6.-Choco Krispi............15Bs");
                Console.WriteLine("7.-Unircorn Froot Loops....15Bs");
                Console.WriteLine("8.-Rice Krispies...........15Bs");
                Console.WriteLine("9.-Froot loops.............15Bs");
                Console.WriteLine("10.-Chocapic...............25Bs");
                Console.WriteLine("11.-Golden Grahams.........25Bs");
                Console.WriteLine("12.-Smocks.................25BS");
                Console.WriteLine("13.-Trix...................25Bs");
                Console.WriteLine("14.-All-Bran choce.........30BS");
                Console.WriteLine("15.-Nesquik................30Bs");


                int i1 = 0;
                i1 = Convert.ToInt16(Console.ReadLine());
                switch (i1)
                {
                    case 1:

                        suma = suma + 10;
                        cant = cant + "     Miel Pops        10Bs" + "\n " + "\n";

                        break;

                    case 2:

                        suma = suma + 10;
                        cant = cant + "   Rellenos de leche  10Bs" + "\n " + "\n";

                        break;

                    case 3:

                        suma = suma + 10;
                        cant = cant + "      Milo            10Bs" + "\n " + "\n";

                        break;

                    case 4:

                        suma = suma + 15;
                        cant = cant + "       Kelluy         15Bs" + "\n " + "\n";

                        break;

                    case 5:

                        suma = suma + 15;
                        cant = cant + "       Froties         15Bs" + "\n " + "\n";

                        break;

                    case 6:

                        suma = suma + 15;
                        cant = cant + "        Choco Krispis  15Bs" + "\n " + "\n";

                        break;

                    case 7:

                        suma = suma + 15;
                        cant = cant + " Unircorn Froot Loops  15Bs" + "\n " + "\n";

                        break;

                    case 8:

                        suma = suma + 15;
                        cant = cant + "    Rice Krispies      15Bs" + "\n " + "\n";

                        break;

                    case 9:

                        suma = suma + 15;
                        cant = cant + "    Froot loops        15Bs" + "\n " + "\n";

                        break;

                    case 10:

                        suma = suma + 25;
                        cant = cant + "    Chocapic           25Bs" + "\n " + "\n";

                        break;

                    case 11:

                        suma = suma + 25;
                        cant = cant + "   Golden Grahams      25Bs" + "\n " + "\n";

                        break;

                    case 12:

                        suma = suma + 25;
                        cant = cant + "       Smocks          25Bs" + "\n " + "\n";

                        break;

                    case 13:

                        suma = suma + 25;
                        cant = cant + "        Trix          25Bs" + "\n " + "\n";

                        break;

                    case 14:

                        suma = suma + 30;
                        cant = cant + "    All-Bran choce    30Bs" + "\n " + "\n";

                        break;

                    case 15:

                        suma = suma + 30;
                        cant = cant + "      Nesquick        30Bs" + "\n " + "\n";

                        break;

                }
                Console.WriteLine(suma + "Bs");
                Console.WriteLine("desea continuar?. si o no.");
                respuesta = Console.ReadLine();

            } while (respuesta != "no");
            Console.WriteLine("gracias por su compra");
            Console.WriteLine(suma + "Bs");


            Console.ReadKey();
        }
    }
}
