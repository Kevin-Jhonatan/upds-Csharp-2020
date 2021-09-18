using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            float suma = 0;
            string respuesta,cant="";
            do
            {
                Console.WriteLine("la seccion de refrescos ofrece lo siguiente:");
                Console.WriteLine("1.-Pepsi Light..............Bs9");
                Console.WriteLine("2.-Lata Imperial............Bs5");
                Console.WriteLine("3.-Lata Huari...............Bs9");
                Console.WriteLine("4.-Ades Sabor Durazno .....Bs10");
                Console.WriteLine("5.-Ades Sabor Manzana......Bs10");
                Console.WriteLine("6.-Pepsi de 3l.............Bs10");
                Console.WriteLine("7.-7up de  3l..............Bs10");
                Console.WriteLine("8.-Refresco De Guarana.....Bs10");
                Console.WriteLine("9.-Coca Cola de 3l.........Bs13");
                Console.WriteLine("10.-Fanta de 3l............Bs13");
                Console.WriteLine("11.-Sprite de 3l...........Bs13");
                Console.WriteLine("12.-Redbul.................Bs16");
                Console.WriteLine("13.-Monster Energy.........Bs16");
                Console.WriteLine("14.-Four Loko Sabor Sandia.Bs27");
                Console.WriteLine("15.-Four Loko Sabor Uva....Bs27");
                Console.WriteLine("16.-Vino Tinto.............Bs26");
                Console.WriteLine("17.-Flor De Caña...........Bs73");
                Console.WriteLine("18.-Fernet.................Bs75");
                Console.WriteLine("19.-Fernet De Menta........Bs75");
                Console.WriteLine("20.-Whisky Johnie.........Bs135");

                int i1 = 0;
                i1 = Convert.ToInt16(Console.ReadLine());
                switch (i1)
                {
                    case 1:

                        suma = suma + 9;
                        cant = cant + "       Pepsi Ligth 9Bs" + "\n " + "\n";

                        break;

                    case 2:

                        suma = suma + 5;
                        cant = cant + "       Lata Imperial 5Bs" + "\n " + "\n";

                        break;

                    case 3:

                        suma = suma + 9;
                        cant = cant + "       Lata Huari 9Bs" + "\n " + "\n";

                        break;

                    case 4:

                        suma = suma + 10;
                        cant = cant + "       Ades Sabor Durazno 10Bs" + "\n " + "\n";

                        break;

                    case 5:

                        suma = suma + 10;
                        cant = cant + "       Ades Sabor Manzana 10Bs" + "\n " + "\n";

                        break;

                    case 6:

                        suma = suma + 10;
                        cant = cant + "        Pepsi de 3l       10Bs" + "\n " + "\n";

                        break;

                    case 7:

                        suma = suma + 10;
                        cant = cant + "       7Up de 3l          10Bs" + "\n " + "\n";

                        break;

                    case 8:

                        suma = suma + 10;
                        cant = cant + "    Refresco De Guarana  10Bs" + "\n " + "\n";

                        break;

                    case 9:

                        suma = suma + 15;
                        cant = cant + "    Coca Cola de 3l     13Bs" + "\n " + "\n";

                        break;

                    case 10:

                        suma = suma + 13;
                        cant = cant + "    Fanta de 3l         13Bs" + "\n " + "\n";

                        break;

                    case 11:

                        suma = suma + 13;
                        cant = cant + "    Sprite De 3l        13Bs" + "\n " + "\n";

                        break;

                    case 12:

                        suma = suma + 16;
                        cant = cant + "       Redbul           16Bs" + "\n " + "\n";

                        break;

                    case 13:

                        suma = suma + 16;
                        cant = cant + "    Monster Energy      16Bs" + "\n " + "\n";

                        break;

                    case 14:

                        suma = suma + 27;
                        cant = cant + "  Four Loko sabor sandia  27Bs" + "\n " + "\n";

                        break;

                    case 15:

                        suma = suma + 27;
                        cant = cant + " Four Loko sabor sandia   27Bs" + "\n " + "\n";

                        break;

                    case 16:

                        suma = suma + 26;
                        cant = cant + "       Vino Tinto         26Bs" + "\n " + "\n";

                        break;

                    case 17:

                        suma = suma + 73;
                        cant = cant + "      Flor de Caña        73Bs" + "\n " + "\n";

                        break;

                    case 18:

                        suma = suma + 75;
                        cant = cant + "         Fernet           75Bs" + "\n " + "\n";

                        break;

                    case 19:

                        suma = suma + 75;
                        cant = cant + "    Fernet de Menta       75Bs" + "\n " + "\n";

                        break;

                    case 20:

                        suma = suma + 135;
                        cant = cant + "      Whisky Johnie      135Bs" + "\n " + "\n";

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
