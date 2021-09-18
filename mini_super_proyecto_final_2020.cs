using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opciones del Menu
            Console.WriteLine("               ............PROYECTO FINAL 2020..........");
            Console.WriteLine("");
            Console.WriteLine("  Elige una opcion :  ");
            Console.WriteLine("");
            Console.WriteLine("1.-   Ejercicio N° 1 STORE      ");
            Console.WriteLine("2.-   Ejercicio N° 2 El Colgado ");
            Console.WriteLine("3.-   **$$...Nombre e Integrantes del Grupo...$$**");
            Console.WriteLine("4.-   Salir  ");

            int menumatriz = 0;
            menumatriz = int.Parse(Console.ReadLine());
            switch (menumatriz)
            {
                case 1:
                    {
                        float suma = 0;
                        string respuesta, cant = "";
                        Console.WriteLine(" ...............................................");
                        Console.WriteLine(" .                                             .");
                        Console.WriteLine(" .   Bienvenido al Micromercado Crazy Market   .");
                        Console.WriteLine(" .                                             .");
                        Console.WriteLine(" ...............................................");
                        Console.WriteLine();
                        Console.WriteLine(" Elija una Opción de la Lista de Secciones");
                        Console.WriteLine();

                        do
                        {
                            Console.WriteLine("    ....Lista de las Secciones....   ");
                            Console.WriteLine();
                            Console.WriteLine("1.  Bebidas                ");
                            Console.WriteLine();
                            Console.WriteLine("2.  Dulces y Galletas      ");
                            Console.WriteLine();
                            Console.WriteLine("3.  Articulos de Limpieza  ");
                            Console.WriteLine();
                            Console.WriteLine("4.  Cereales               ");
                            Console.WriteLine();
                            Console.WriteLine("5.  Lacteos                ");
                            Console.WriteLine();
                            Console.WriteLine("6.  Frutas y Verduras      ");

                            Console.WriteLine();

                            int i1 = 0;
                            i1 = Convert.ToInt16(Console.ReadLine());
                            switch (i1)
                            {
                                case 1:
                                    Console.WriteLine("    ....Seccion de Bebidas....   ");
                                    Console.WriteLine();
                                    Console.WriteLine("1.  Pepsi Light ..........................   9 Bs");
                                    Console.WriteLine("2.  Lata Imperial ........................   5 Bs");
                                    Console.WriteLine("3.  Lata Huari ...........................   9 Bs");
                                    Console.WriteLine("4.  Ades Sabor Durazno ...................  10 Bs");
                                    Console.WriteLine("5.  Ades Sabor Manzana ...................  10 Bs");
                                    Console.WriteLine("6.  Pepsi 3L. ............................  10 Bs");
                                    Console.WriteLine("7.  7up 3L. ..............................  10 Bs");
                                    Console.WriteLine("8.  Refresco De Guarana...................  10 Bs");
                                    Console.WriteLine("9.  Coca Cola de 3L. .....................  13 Bs");
                                    Console.WriteLine("10. Fanta 3L. ............................  13 Bs");
                                    Console.WriteLine("11. Sprite 3l.............................  13 Bs");
                                    Console.WriteLine("12. Redbul................................  16 Bs");
                                    Console.WriteLine("13. Monster Energy........................  16 Bs");
                                    Console.WriteLine("14. Four Loko Sabor Sandia................  27 Bs");
                                    Console.WriteLine("15. Four Loko Sabor Uva...................  27 Bs");
                                    Console.WriteLine("16. Vino Tinto............................  26 Bs");
                                    Console.WriteLine("17. Flor De Caña..........................  73 Bs");
                                    Console.WriteLine("18. Fernet................................  75 Bs");
                                    Console.WriteLine("19. Fernet De Menta.......................  75 Bs");
                                    Console.WriteLine("20. Whisky Johnie......................... 135 Bs");
                                    Console.WriteLine();
                                    int u1 = 0;
                                    u1 = Convert.ToInt16(Console.ReadLine());
                                    switch (u1)
                                    {
                                        case 1:
                                            suma = suma + 9;
                                            cant = cant + "        Pepsi Light               9 Bs" + "\n " + "\n";
                                            break;
                                        case 2:
                                            suma = suma + 5;
                                            cant = cant + "        Imperial Lata             5 Bs" + "\n " + "\n";
                                            break;
                                        case 3:
                                            suma = suma + 9;
                                            cant = cant + "        Huari Lata                9 Bs" + "\n " + "\n";
                                            break;
                                        case 4:
                                            suma = suma + 10;
                                            cant = cant + "        Ades Durazno             10 Bs" + "\n " + "\n";
                                            break;
                                        case 5:
                                            suma = suma + 10;
                                            cant = cant + "        Ades Manzana             10 Bs" + "\n " + "\n";
                                            break;
                                        case 6:
                                            suma = suma + 10;
                                            cant = cant + "        Pepsi de 3L.             10 Bs" + "\n " + "\n";
                                            break;
                                        case 7:
                                            suma = suma + 10;
                                            cant = cant + "        7Up de 3L.                10Bs" + "\n " + "\n";
                                            break;
                                        case 8:
                                            suma = suma + 10;
                                            cant = cant + "        Fanta Guarana 3L.        10 Bs" + "\n " + "\n";
                                            break;
                                        case 9:
                                            suma = suma + 15;
                                            cant = cant + "        Coca Cola 3L.            13 Bs" + "\n " + "\n";
                                            break;
                                        case 10:
                                            suma = suma + 13;
                                            cant = cant + "        Fanta 3L.                13 Bs" + "\n " + "\n";
                                            break;
                                        case 11:
                                            suma = suma + 13;
                                            cant = cant + "        Sprite 3L,               13 Bs" + "\n " + "\n";
                                            break;
                                        case 12:
                                            suma = suma + 16;
                                            cant = cant + "        Redbul                   16 Bs" + "\n " + "\n";
                                            break;
                                        case 13:
                                            suma = suma + 16;
                                            cant = cant + "        Monster Energy           16 Bs" + "\n " + "\n";
                                            break;
                                        case 14:
                                            suma = suma + 27;
                                            cant = cant + "        Four Loko Sabor Sandia   27 Bs" + "\n " + "\n";
                                            break;
                                        case 15:
                                            suma = suma + 27;
                                            cant = cant + "        Four Loko Sabor Uva      27 Bs" + "\n " + "\n";
                                            break;
                                        case 16:
                                            suma = suma + 26;
                                            cant = cant + "        Vino Tinto               26 Bs" + "\n " + "\n";
                                            break;
                                        case 17:
                                            suma = suma + 73;
                                            cant = cant + "        Flor de Caña             73 Bs" + "\n " + "\n";
                                            break;
                                        case 18:
                                            suma = suma + 75;
                                            cant = cant + "        Fernet                   75 Bs" + "\n " + "\n";
                                            break;
                                        case 19:
                                            suma = suma + 75;
                                            cant = cant + "        Fernet Menta             75 Bs" + "\n " + "\n";
                                            break;
                                        case 20:
                                            suma = suma + 135;
                                            cant = cant + "        Whisky Johnie           135 Bs" + "\n " + "\n";
                                            break;
                                        default:
                                            Console.WriteLine("....Este Valor No Esta Disponible intente con otro....");
                                            break;

                                    }
                                    break;
                                case 2:

                                    Console.WriteLine("    ....Seccion de Galletas....   ");
                                    Console.WriteLine();
                                    Console.WriteLine("1.  Club Social ..........................   2 Bs");
                                    Console.WriteLine("2.  Gauchitas ............................   3 Bs");
                                    Console.WriteLine("3.  Moraditas ............................   3 Bs");
                                    Console.WriteLine("4.  Maria ................................   3 Bs");
                                    Console.WriteLine("5.  Oreo .................................   3 Bs");
                                    Console.WriteLine("6.  Papas Frita pequeño ..................   5 Bs");
                                    Console.WriteLine("7.  CracKers .............................   5 Bs");
                                    Console.WriteLine("8.  Chips Ahoy! ..........................   5 Bs");
                                    Console.WriteLine("9.  Choco Soda ...........................   5 Bs");
                                    Console.WriteLine("10. Wafers ...............................   5 Bs");
                                    Console.WriteLine("11. Ducales ..............................   7 Bs");
                                    Console.WriteLine("12. Choco Chip ...........................   7 Bs");
                                    Console.WriteLine("13. Salvado ..............................   9 Bs");
                                    Console.WriteLine("14. Champagne ............................  10 Bs");
                                    Console.WriteLine("15. San Gabriel ..........................  10 Bs");
                                    Console.WriteLine("16. Papas Fritas Grande ..................  15 Bs");
                                    Console.WriteLine("17. Chocolate Bauducco ...................  20 Bs");
                                    Console.WriteLine("18. Praline ..............................  20 Bs");
                                    Console.WriteLine("19. Chocolate Bom o bom ..................  20 Bs");
                                    Console.WriteLine("20. Ferrari Integral 1 kg. ...............  25 Bs");
                                    Console.WriteLine();

                                    int c1 = 0;
                                    c1 = int.Parse(Console.ReadLine());
                                    switch (c1)
                                    {
                                        case 1:
                                            suma = suma + 2;
                                            cant = cant + "        Club Social               2 Bs" + " \n " + "\n";
                                            break;
                                        case 2:
                                            suma = suma + 3;
                                            cant = cant + "        Gauchitas                 3 Bs" + " \n " + "\n";
                                            break;
                                        case 3:
                                            suma = suma + 3;
                                            cant = cant + "        Moraditas                 3 Bs" + "\n" + "\n";
                                            break;
                                        case 4:
                                            suma = suma + 3;
                                            cant = cant + "        Maria                     3 Bs" + "\n" + "\n";
                                            break;
                                        case 5:
                                            suma = suma + 3;
                                            cant = cant + "        Oreo                      3 Bs" + "\n" + "\n";
                                            break;
                                        case 6:
                                            suma = suma + 5;
                                            cant = cant + "        Papas Fritas Pequeño      5 Bs" + "\n" + "\n";
                                            break;
                                        case 7:
                                            suma = suma + 5;
                                            cant = cant + "        Crackers                  5 Bs" + "\n" + "\n";
                                            break;
                                        case 8:
                                            suma = suma + 5;
                                            cant = cant + "        Chips Ahoy!               5 Bs" + "\n" + "\n";
                                            break;
                                        case 9:
                                            suma = suma + 5;
                                            cant = cant + "        Choco Soda                5 Bs" + "\n" + "\n";
                                            break;
                                        case 10:
                                            suma = suma + 5;
                                            cant = cant + "        Wafers                    5 Bs" + "\n" + "\n";
                                            break;
                                        case 11:
                                            suma = suma + 7;
                                            cant = cant + "        Ducales                   7 Bs" + "\n" + "\n";
                                            break;
                                        case 12:
                                            suma = suma + 7;
                                            cant = cant + "        Choco Chip                7 Bs" + "\n" + "\n";
                                            break;
                                        case 13:
                                            suma = suma + 9;
                                            cant = cant + "        Salvado                   9 Bs" + "\n" + "\n";
                                            break;
                                        case 14:
                                            suma = suma + 10;
                                            cant = cant + "        Champagne                10 Bs" + "\n" + "\n";
                                            break;
                                        case 15:
                                            suma = suma + 10;
                                            cant = cant + "        San Gabriel              10 Bs" + "\n" + "\n";
                                            break;
                                        case 16:
                                            suma = suma + 15;
                                            cant = cant + "        Papas Fritas Grande      15 Bs" + "\n" + "\n";
                                            break;
                                        case 17:
                                            suma = suma + 20;
                                            cant = cant + "        Chocolate Bauduco        20 Bs" + "\n" + "\n";
                                            break;
                                        case 18:
                                            suma = suma + 20;
                                            cant = cant + "        Praline                  20 Bs" + "\n" + "\n";
                                            break;
                                        case 19:
                                            suma = suma + 20;
                                            cant = cant + "        Chocolate Bon o Bon      20 Bs" + "\n" + "\n";
                                            break;
                                        case 20:
                                            suma = suma + 25;
                                            cant = cant + "        Ferrari Integral 1 kg    25 Bs" + "\n" + "\n";
                                            break;
                                        default:
                                            Console.WriteLine("....Este Valor No Esta Disponible intente con otro....");
                                            break;
                                    }


                                    break;
                                case 3:
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

                                    int o1 = 0;
                                    o1 = Convert.ToInt16(Console.ReadLine());
                                    switch (o1)
                                    {
                                        case 1:
                                            suma = suma + 65;   // objeto                   precio 
                                            cant = cant + "        Detergente OMO 3kl.      65 Bs" + "\n " + "\n";
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
                                        default:
                                            Console.WriteLine("....Este Valor No Esta Disponible intente con otro....");
                                            break;


                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("    ....Seccion de Cereales....   ");
                                    Console.WriteLine();
                                    Console.WriteLine("1.  Miel Pops ............................  10 Bs");
                                    Console.WriteLine("2.  Rellenos de Leche ....................  10 Bs");
                                    Console.WriteLine("3.  Milo .................................  18 Bs");
                                    Console.WriteLine("4.  Chocopotamos .........................  16 Bs");
                                    Console.WriteLine("5.  Froties ..............................  15 Bs");
                                    Console.WriteLine("6.  hoco Krispi ..........................  15 Bs");
                                    Console.WriteLine("7.  Unircorn Froot Loops .................  15 Bs");
                                    Console.WriteLine("8.  Rice Krispies ........................  15 Bs");
                                    Console.WriteLine("9.  Froot loops ..........................  16 Bs");
                                    Console.WriteLine("10. Chocapic .............................  27 Bs");
                                    Console.WriteLine("11. Golden Grahams .......................  25 Bs");
                                    Console.WriteLine("12. Smocks ...............................  25 BS");
                                    Console.WriteLine("13. Trix .................................  25 Bs");
                                    Console.WriteLine("14. All-Bran choce .......................  30 BS");
                                    Console.WriteLine("15. Nesquik ..............................  30 Bs");
                                    Console.WriteLine();

                                    int a1 = 0;
                                    a1 = Convert.ToInt16(Console.ReadLine());
                                    switch (a1)
                                    {
                                        case 1:
                                            suma = suma + 10;
                                            cant = cant + "        Miel Pops                10 Bs" + "\n " + "\n";
                                            break;
                                        case 2:
                                            suma = suma + 10;
                                            cant = cant + "        Rellenos de leche        10 Bs" + "\n " + "\n";
                                            break;
                                        case 3:
                                            suma = suma + 18;
                                            cant = cant + "        Milo                     18 Bs" + "\n " + "\n";
                                            break;
                                        case 4:
                                            suma = suma + 16;
                                            cant = cant + "        Chocopotamos             16 Bs" + "\n " + "\n";
                                            break;
                                        case 5:
                                            suma = suma + 15;
                                            cant = cant + "        Froties                  15 Bs" + "\n " + "\n";
                                            break;
                                        case 6:
                                            suma = suma + 15;
                                            cant = cant + "        Choco Krispis            15 Bs" + "\n " + "\n";
                                            break;
                                        case 7:
                                            suma = suma + 15;
                                            cant = cant + "        Unircorn Froot Loops     15 Bs" + "\n " + "\n";
                                            break;
                                        case 8:
                                            suma = suma + 15;
                                            cant = cant + "        Rice Krispies            15 Bs" + "\n " + "\n";
                                            break;
                                        case 9:
                                            suma = suma + 16;
                                            cant = cant + "        Froot loops              16 Bs" + "\n " + "\n";
                                            break;
                                        case 10:
                                            suma = suma + 27;
                                            cant = cant + "        Chocapic                 27 Bs" + "\n " + "\n";
                                            break;
                                        case 11:
                                            suma = suma + 25;
                                            cant = cant + "        Golden Grahams           25 Bs" + "\n " + "\n";
                                            break;
                                        case 12:
                                            suma = suma + 25;
                                            cant = cant + "        Smocks                   25 Bs" + "\n " + "\n";
                                            break;
                                        case 13:
                                            suma = suma + 25;
                                            cant = cant + "        Trix                     25 Bs" + "\n " + "\n";
                                            break;
                                        case 14:
                                            suma = suma + 30;
                                            cant = cant + "        All-Bran choce           30 Bs" + "\n " + "\n";
                                            break;
                                        case 15:
                                            suma = suma + 30;
                                            cant = cant + "        Nesquick                 30 Bs" + "\n " + "\n";
                                            break;
                                        default:
                                            Console.WriteLine("....Este Valor No Esta Disponible intente con otro....");
                                            break;

                                    }
                                    break;
                                case 5:
                                    Console.WriteLine("    ....Seccion de Lacteos....   ");
                                    Console.WriteLine();
                                    Console.WriteLine("1.  Leche Light ..........................   7 Bs");
                                    Console.WriteLine("2.  Leche Deslactosada ...................   8 Bs");
                                    Console.WriteLine("3.  Manjar 1kl. ..........................  35 Bs");
                                    Console.WriteLine("4.  Leche Natural ........................   6 Bs");
                                    Console.WriteLine("5.  Leche Condesada ......................  12 Bs");
                                    Console.WriteLine("6.  Leche Evaporada ......................  13 Bs");
                                    Console.WriteLine("7.  Queso Premier ........................  45 Bs");
                                    Console.WriteLine("8.  Yogurt Delicia Frutilla ..............  15 Bs");
                                    Console.WriteLine("9.  Yogurt Delicia Durazno ...............  15 Bs");
                                    Console.WriteLine("10. Yogurt Delicia Coco ..................  15 Bs");
                                    Console.WriteLine("11. Mantequilla Regia ....................  20 Bs");
                                    Console.WriteLine("12. Leche en Polvo .......................  18 Bs");
                                    Console.WriteLine("13. Helado Pil  ..........................  20 Bs");
                                    Console.WriteLine("14. Helado Norlan  .......................  10 Bs");
                                    Console.WriteLine("15. Yogurt Griego Dlicia .................   7 Bs");
                                    Console.WriteLine("16. Pilfrut durazno ......................   1 Bs");
                                    Console.WriteLine();

                                    int w1 = 0;
                                    w1 = Convert.ToInt16(Console.ReadLine());
                                    switch (w1)
                                    {
                                        case 1:
                                            suma = suma + 7;
                                            cant = cant + "        Leche Light               7 Bs" + "\n " + "\n";
                                            break;
                                        case 2:
                                            suma = suma + 8;
                                            cant = cant + "        Leche deslactosada        8 Bs" + "\n " + "\n";
                                            break;
                                        case 3:
                                            suma = suma + 35;
                                            cant = cant + "        Manjar 1kl.              35 Bs" + "\n " + "\n";
                                            break;
                                        case 4:
                                            suma = suma + 6;
                                            cant = cant + "        Leche Natural             6 Bs" + "\n " + "\n";
                                            break;
                                        case 5:
                                            suma = suma + 12;
                                            cant = cant + "        Leche Condesada          12 Bs" + "\n " + "\n";
                                            break;
                                        case 6:
                                            suma = suma + 13;
                                            cant = cant + "        Leche Evaporada          13 Bs" + "\n " + "\n";
                                            break;
                                        case 7:
                                            suma = suma + 45;
                                            cant = cant + "        Queso Premier            45 Bs" + "\n " + "\n";
                                            break;
                                        case 8:
                                            suma = suma + 15;
                                            cant = cant + "        Yogurt Delicia Frutilla  15 Bs" + "\n " + "\n";
                                            break;
                                        case 9:
                                            suma = suma + 15;
                                            cant = cant + "        Yogurt Delicia Durazno   15 Bs" + "\n " + "\n";
                                            break;
                                        case 10:
                                            suma = suma + 15;
                                            cant = cant + "        Yogurt Delicia Coco      15 Bs" + "\n " + "\n";
                                            break;
                                        case 11:
                                            suma = suma + 20;
                                            cant = cant + "        Mantequilla Regia        20 Bs" + "\n " + "\n";
                                            break;
                                        case 12:
                                            suma = suma + 18;
                                            cant = cant + "        Leche en Polvo           18 Bs" + "\n " + "\n";
                                            break;
                                        case 13:
                                            suma = suma + 20;
                                            cant = cant + "        Helado Pil               20 Bs" + "\n " + "\n";
                                            break;
                                        case 14:
                                            suma = suma + 10;
                                            cant = cant + "        Helado Norlan            10 Bs" + "\n " + "\n";
                                            break;
                                        case 15:
                                            suma = suma + 7;
                                            cant = cant + "        Yogurt Griego Delicia     7 Bs" + "\n " + "\n";
                                            break;
                                        case 16:
                                            suma = suma + 1;
                                            cant = cant + "        Pilfrut durazno           1 Bs" + "\n " + "\n";
                                            break;
                                        default:
                                            Console.WriteLine("....Este Valor No Esta Disponible intente con otro....");
                                            break;
                                    }
                                    break;
                                case 6:
                                    Console.WriteLine("    ....Seccion de Frutas y Verduras....   ");
                                    Console.WriteLine();
                                    Console.WriteLine("1.  Manzana Verde 1kl. ...................  10 Bs ");
                                    Console.WriteLine("2.  Chirimolla 1kl. ......................  20 Bs ");
                                    Console.WriteLine("3.  Durazno 1kl. .........................  15 Bs ");
                                    Console.WriteLine("4.  Frutilla 1 Pqte. .....................  10 Bs ");
                                    Console.WriteLine("5.  Ciruelo 1 Pqte. ......................   8 Bs ");
                                    Console.WriteLine("6.  Mora 1 Pqte. .........................  15 Bs ");
                                    Console.WriteLine("7.  Uva 1 Pqte. ..........................  14 Bs ");
                                    Console.WriteLine("8.  Arandanos 1 Pqte. ....................  17 Bs ");
                                    Console.WriteLine("9.  Limon 1kl. ...........................  12 Bs ");
                                    Console.WriteLine("10. Sandia 1U. ...........................  32 Bs ");
                                    Console.WriteLine("11. Melon 1U. ............................  10 Bs ");
                                    Console.WriteLine("12. Piña 1U.  ............................  10 Bs ");
                                    Console.WriteLine("13. Zanohoria 1kl. .......................   6 Bs ");
                                    Console.WriteLine("14. Cebolla 1kl. .........................   7 Bs ");
                                    Console.WriteLine("15. Tomate 1kl. ..........................   5 Bs ");
                                    Console.WriteLine("16. Navo 1kl. ............................   8 Bs ");
                                    Console.WriteLine("17. Papa 1kl. ............................  12 Bs ");
                                    Console.WriteLine("18. Pimenton 1U. .........................   5 Bs ");
                                    Console.WriteLine("19. Brocoli 1U. ..........................   9 Bs ");
                                    Console.WriteLine("20. Palta 1U. ............................  10 Bs ");
                                    Console.WriteLine("21. Repollo 1U. ..........................   6 Bs ");
                                    Console.WriteLine("22. Berenjena 1U. ........................   8 Bs ");
                                    Console.WriteLine("23. Lechuga 1Bol. ........................   5 Bs ");
                                    Console.WriteLine();

                                    int b1 = 0;
                                    b1 = int.Parse(Console.ReadLine());
                                    switch (b1)
                                    {
                                        case 1:
                                            suma = suma + 10;   // objeto                   precio 
                                            cant = cant + "        Manzana Verde 1kl.       10 Bs" + "\n " + "\n";
                                            break;
                                        case 2:
                                            suma = suma + 20;
                                            cant = cant + "        Chirimolla 1kl.          20 Bs" + "\n " + "\n";
                                            break;
                                        case 3:
                                            suma = suma + 15;
                                            cant = cant + "        Durazno 1kl.             15 Bs" + "\n " + "\n";
                                            break;
                                        case 4:
                                            suma = suma + 10;
                                            cant = cant + "        Frutilla 1 Pqte.         10 Bs" + "\n " + "\n";
                                            break;
                                        case 5:
                                            suma = suma + 8;
                                            cant = cant + "        Ciruelo 1 Pqte.           8 Bs" + "\n " + "\n";
                                            break;
                                        case 6:
                                            suma = suma + 15;
                                            cant = cant + "        Mora 1 Pqte.             15 Bs" + "\n " + "\n";
                                            break;
                                        case 7:
                                            suma = suma + 14;
                                            cant = cant + "        Uva 1 Pqte.              14 Bs" + "\n " + "\n";
                                            break;
                                        case 8:
                                            suma = suma + 17;
                                            cant = cant + "        Arandanos 1 Pqte.        17 Bs" + "\n " + "\n";
                                            break;
                                        case 9:
                                            suma = suma + 12;
                                            cant = cant + "        Limon 1kl.               12 Bs" + "\n " + "\n";
                                            break;
                                        case 10:
                                            suma = suma + 32;
                                            cant = cant + "        Sandia 1U.               32 Bs" + "\n " + "\n";
                                            break;
                                        case 11:
                                            suma = suma + 10;
                                            cant = cant + "        Melon 1U.                10 Bs" + "\n " + "\n";
                                            break;
                                        case 12:
                                            suma = suma + 10;
                                            cant = cant + "        Piña 1U.                 10 Bs" + "\n " + "\n";
                                            break;
                                        case 13:
                                            suma = suma + 6;
                                            cant = cant + "        Zanohoria 1kl.            6 Bs" + "\n " + "\n";
                                            break;
                                        case 14:
                                            suma = suma + 7;
                                            cant = cant + "        Cebolla 1kl.              7 Bs" + "\n " + "\n";
                                            break;
                                        case 15:
                                            suma = suma + 5;
                                            cant = cant + "        Tomate 1kl.               5 Bs" + "\n " + "\n";
                                            break;
                                        case 16:
                                            suma = suma + 8;
                                            cant = cant + "        Navo 1kl.                 8 Bs" + "\n " + "\n";
                                            break;
                                        case 17:
                                            suma = suma + 12;
                                            cant = cant + "        Papa 1kl.                12 Bs" + "\n " + "\n";
                                            break;
                                        case 18:
                                            suma = suma + 5;
                                            cant = cant + "        Pimenton 1U.              5 Bs" + "\n " + "\n";
                                            break;
                                        case 19:
                                            suma = suma + 9;
                                            cant = cant + "        Brocoli 1U.               9 Bs" + "\n " + "\n";
                                            break;
                                        case 20:
                                            suma = suma + 10;
                                            cant = cant + "        Palta 1U.                10 Bs" + "\n " + "\n";
                                            break;
                                        case 21:
                                            suma = suma + 6;
                                            cant = cant + "        Repollo 1U.               6 Bs" + "\n " + "\n";
                                            break;
                                        case 22:
                                            suma = suma + 8;
                                            cant = cant + "        Berenjena 1U.             8 Bs" + "\n " + "\n";
                                            break;
                                        case 23:
                                            suma = suma + 5;
                                            cant = cant + "        Lechuga 1Bol.             5 Bs" + "\n " + "\n";
                                            break;
                                        default:
                                            Console.WriteLine("....Este Valor No Esta Disponible intente con otro....");
                                            break;




                                    }
                                    break;
                                default:
                                    Console.WriteLine("....Este Valor No Esta Disponible intente con otro....");
                                    break;
                            }
                            Console.WriteLine();
                            Console.WriteLine("Suma Actual :  " + suma + " Bs");
                            Console.WriteLine();
                            Console.WriteLine("Desea comprar otro producto...... Si o No...  ");
                            respuesta = Console.ReadLine();
                        } while (respuesta != "no");

                        Console.WriteLine("...........................................");

                        Console.Write("Ingrese nombre:       ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese el NIT/CI.:   ");
                        double nit = double.Parse(Console.ReadLine());
                        Console.Write("Nombre del vendedor:  ");
                        string vendedor = Console.ReadLine();
                        Console.WriteLine("Monto total a pagar       " + suma);
                        Console.Write("Pago realizado            ");
                        double pagar = double.Parse(Console.ReadLine());
                        double cambio = pagar - suma;


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
                        Console.WriteLine("        CONCEPTO           " + "    IMPORTE");
                        Console.WriteLine("...........................................");
                        Console.WriteLine(cant);
                        Console.WriteLine("...........................................");
                        Console.WriteLine("        Total:                  "  + suma   + " Bs");
                        Console.WriteLine();
                        Console.WriteLine("        Pago Efectivo:          "  + pagar  + " Bs");
                        Console.WriteLine();
                        Console.WriteLine("        Cambio:                 "  + cambio + " Bs");
                        Console.WriteLine();
                        Console.WriteLine("        Emitodo por:  " + vendedor);
                        Console.WriteLine();
                        Console.WriteLine("...Gracias por su compra ¡¡!! Vuelva Pronto...");
                        Console.ReadKey();
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("                         ..........PROYECTO FINAL 2020..........  Fecha :09-03-20");
                        Console.WriteLine("             Grupo : Equipo Alfa Buena Maravilla Onda Dinamita Escuadrón Lobo ");
                        Console.WriteLine("             Docente : Lic. Maria Antonieta Vallejos Troncoso");
                        Console.WriteLine("          Integrantes :");
                        Console.WriteLine("1.- Kevin Jhonatan Mamani Mollo");
                        Console.WriteLine("2.- José Antonio Castro Alvis");
                        Console.WriteLine("3.- Jamil Nayguel Castro Dias");
                        Console.ReadLine();
                        break;
                    }
                default:
                    Console.WriteLine("    No se ha seleccionado una opcion ");
                    Console.WriteLine("         termino el programa :");
                    Console.ReadKey();
                    break;
                case 4:
                    break;
            }
           
        }
    }
}
