using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            float suma = 0;
            string respuesta,cant="";
            do
            {
                Console.WriteLine("    ....Seccion de limpiesa....   ");
                Console.WriteLine();
                Console.WriteLine("1.  Detergente OMO 3kl. ..................  65 Bs ");
                Console.WriteLine("2.  Detergente Ace 1kl. ..................  20 Bs ");
                Console.WriteLine("3.  Detergente liquido 1L. ...............  75 Bs ");
                Console.WriteLine("4.  Suavisante de ropa 1l. ...............  67 Bs ");
                Console.WriteLine("5.  jaboncillo Dove ......................   8 Bs ");
                Console.WriteLine("6.  Shampoo Sedal ........................  22 Bs ");
                Console.WriteLine("7.  Crema dental Colgate .................  10 Bs ");
                Console.WriteLine("8.  Cepillo dental .......................  20 Bs ");
                Console.WriteLine("9.  Pack Escoba + lebantador de basura ...  45 Bs ");
                Console.WriteLine("10. Antisarro OLA ........................  20 Bs ");
                Console.WriteLine("11. Limpia Vidrio OLA ....................  19 Bs ");
                Console.WriteLine("12. Antigrasa OLA  .......................  19 Bs ");
                Console.WriteLine("13. Antitranspirante Rexona ..............  42 Bs ");
                Console.WriteLine("14. Antitraspirante Old Spice ............  25 Bs ");
                Console.WriteLine("15. Lava Vajilla Archer ..................  19 Bs ");
                Console.WriteLine("16. Ambientador ..........................  15 Bs ");
                Console.WriteLine("17. Enjuage Bucal Colgate ................  45 Bs ");
                Console.WriteLine("18. Jabón Bolivar ........................   5 Bs ");
                Console.WriteLine("19. Esponja Scotch Brite .................  25 Bs ");
                Console.WriteLine("20. Lavandina Mr.Flash ...................   1 Bs ");
                Console.WriteLine("21. Alcohol en Gel OLA ...................  30 Bs ");
                Console.WriteLine();

                int i1 = 0;
                i1 = Convert.ToInt16(Console.ReadLine());
                switch (i1)
                {
                    case 1:
                        suma = suma + 65;   // objeto                   precio 
                        cant = cant + "        Detergente OMO 3kl.      65 Bs" + "\n "+"\n";
                        break;
                    case 2:
                        suma = suma + 20;   
                        cant = cant + "        Detergente Ace 1kl.      20 Bs" + "\n " + "\n";
                        break;
                    case 3:
                        suma = suma + 75;
                        cant = cant + "        Detergente liquido 1L.   75 Bs" + "\n " + "\n";
                        break;
                    case 4:
                        suma = suma + 67;
                        cant = cant + "        Suavisante de ropa 1l.   67 Bs" + "\n " + "\n";
                        break;
                    case 5:
                        suma = suma + 8;
                        cant = cant + "        Jaboncillo Dove           8 Bs" + "\n " + "\n";
                        break;
                    case 6:
                        suma = suma + 22;
                        cant = cant + "        Shampoo Sedal            22 Bs" + "\n " + "\n";
                        break;
                    case 7: 
                        suma = suma + 10;   
                        cant = cant + "        Crema dental Colgate     10 Bs" + "\n " + "\n";
                        break;
                    case 8:
                        suma = suma + 20;   
                        cant = cant + "        Cepillo dental           20 Bs" + "\n " + "\n";
                        break;
                    case 9:
                        suma = suma + 45;
                        cant = cant + "        Pack Escoba+Levantador   45 Bs" + "\n " + "\n";
                        break;
                    case 10:
                        suma = suma + 20;
                        cant = cant + "        Antisarro OLA            20 Bs" + "\n " + "\n";
                        break;
                    case 11:
                        suma = suma + 19;
                        cant = cant + "        Limpia Vidrio OLA        19 Bs" + "\n " + "\n";
                        break;
                    case 12:
                        suma = suma + 19;
                        cant = cant + "        Antigrasa OLA            19 Bs" + "\n " + "\n";
                        break;
                    case 13:
                        suma = suma + 42;   
                        cant = cant + "        Antitranspirante Rexona  42 Bs" + "\n " + "\n";
                        break;
                    case 14:
                        suma = suma + 25;   
                        cant = cant + "        Antitraspirante OldSpice 25 Bs" + "\n " + "\n";
                        break;
                    case 15:
                        suma = suma + 19;
                        cant = cant + "        Lava Vajilla Archer      19 Bs" + "\n " + "\n";
                        break;
                    case 16:
                        suma = suma + 15;
                        cant = cant + "        Ambientador              15 Bs" + "\n " + "\n";
                        break;
                    case 17:
                        suma = suma + 45;
                        cant = cant + "        Enjuage Vucal Colgate    45 Bs" + "\n " + "\n";
                        break;
                    case 18:
                        suma = suma + 5;
                        cant = cant + "        Jabón Bolivar             5 Bs" + "\n " + "\n";
                        break;
                    case 19:
                        suma = suma + 25;   
                        cant = cant + "        Esponja Scotch Brite     25 Bs" + "\n " + "\n";
                        break;
                    case 20:
                        suma = suma + 1;   
                        cant = cant + "        Lavandina Mr.Flash        1 Bs" + "\n " + "\n";
                        break;
                    case 21:
                        suma = suma + 30;
                        cant = cant + "        Alcohol en Gel OLA       30 Bs" + "\n " + "\n";
                        break;
                    

                }

                Console.WriteLine();
                Console.WriteLine(suma + " Bs");
                Console.WriteLine();
                Console.WriteLine("...Desea Continuar Con  La Compra....? Si o No...  ");
                respuesta = Console.ReadLine();

            } while (respuesta != "no");

            Console.WriteLine("...........................................");

            Console.Write("Ingrese nombre:       ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese el NIT/CI.:   ");
            int nit = int.Parse(Console.ReadLine());
            Console.Write("Nombre del vendedor: ");
            string vendedor = Console.ReadLine();

            DateTime fecha = DateTime.Now;
            Console.WriteLine("............................................");
            Console.Write("Fecha:        ");
            Console.WriteLine(fecha.ToString("dd/MM/yyyy"));
            Console.WriteLine();
            Console.Write("Hora:         ");
            Console.WriteLine(fecha.ToString("hh:mm:ss"));
            Console.WriteLine();
            Console.WriteLine("Cliente:      " + nombre);
            Console.WriteLine();
            Console.WriteLine("NIT/CI:       " + nit);
            Console.WriteLine("...........................................");
            Console.WriteLine("        CONCEPTO      "+"      IMPORTE");
            Console.WriteLine("...........................................");
            Console.WriteLine( cant);
            Console.WriteLine("...........................................");
            Console.WriteLine("        Total:               " + suma + " Bs");
            Console.WriteLine();
            Console.WriteLine("Emitodo por:  " + vendedor);

            

            Console.ReadKey();
        }
    }
}
