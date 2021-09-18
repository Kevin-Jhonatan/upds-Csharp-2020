int menuprincipal = 0;
            string respuesta,cant="";
            float suma = 0;
            do
            {
                // Opciones del Menu Principal :
                Console.WriteLine("                     ...\\ Bienvenido A Tieda ...Las Islas... /...");
                Console.WriteLine("");
                Console.WriteLine(" Seleccione Una Seccion De Compra  : ");
                Console.WriteLine("");
                Console.Write(" 1.- Seccion Resfrescos                     ");
                Console.WriteLine(" 2.- Seccion Galletas");
                Console.Write(" 3.- Seccion De Limpieza                    ");
                Console.WriteLine(" 4.- Seccion Cereales");
                Console.Write(" 5.- Seccion Frutas Y Verduras              ");
                Console.WriteLine(" 6.- Seccion Farmacia");
                Console.WriteLine("");
                Console.WriteLine("                        7.- Terminar compra ");
                menuprincipal = int.Parse(Console.ReadLine());
                switch (menuprincipal)
                {
                    case 1:
                        {
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
                                Console.WriteLine("17.-Flor De Ca�a...........Bs73");
                                Console.WriteLine("18.-Fernet.................Bs75");
                                Console.WriteLine("19.-Fernet De Menta........Bs75");
                                Console.WriteLine("20.-Whisky Johnie.........Bs135");

                                int menu1 = 0;
                                menu1 = Convert.ToInt16(Console.ReadLine());
                                switch (menu1)
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
                                        cant = cant + "      Flor de Ca�a        73Bs" + "\n " + "\n";

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
                            Console.WriteLine("        CONCEPTO      " + "      IMPORTE");
                            Console.WriteLine("...........................................");
                            Console.WriteLine(cant);
                            Console.WriteLine("...........................................");
                            Console.WriteLine("        Total:               " + suma + " Bs");
                            Console.WriteLine();
                            Console.WriteLine("Emitodo por:  " + vendedor);
                            break;
                        }
                    case 2:
                        {
                          do
                          { 
                            Console.WriteLine("La Seccion De Galletas Ofrece Lo Siguiente  :");
                            Console.WriteLine("");
                            Console.WriteLine("1.-  Club Social............ Bs 2");
                            Console.WriteLine("2.-  Gauchitas.............. Bs 3");
                            Console.WriteLine("3.-  Moraditas.............. Bs 3");
                            Console.WriteLine("4.-  Maria.................. Bs 3");
                            Console.WriteLine("5.-  Oreo................... Bs 3");
                            Console.WriteLine("6.-  Papas Frita peque�o.... Bs 5 ");
                            Console.WriteLine("7.-  CracKers............... Bs 5");
                            Console.WriteLine("8.-  Chips Ahoy!............ Bs 5");
                            Console.WriteLine("9.-  Choco Soda............. Bs 5");
                            Console.WriteLine("10.- Wafers................. Bs 5");
                            Console.WriteLine("11.- Ducales................ Bs 7");
                            Console.WriteLine("12-  Choco Chip............. Bs 7");
                            Console.WriteLine("13.- Salvado................ Bs 9");
                            Console.WriteLine("14.- Champagne.............. Bs 10");
                            Console.WriteLine("15.- San Gabriel............ Bs 10");
                            Console.WriteLine("16.- Papas Fritas Grande.... Bs 15");
                            Console.WriteLine("17.- Chocolate Bauducco..... Bs 20");
                            Console.WriteLine("18.- Praline................ Bs 20");
                            Console.WriteLine("29.- Chocolate Bom o bom.... Bs 20");
                            Console.WriteLine("20.- Ferrari Integral 1 kg.. Bs 25");
                            int menu2 = 0;
                            menu2 = int.Parse(Console.ReadLine());
                            switch (menu2)
                            {
                                case 1:
                                    suma = suma + 2; //Precio Club Social
                                    cant = cant + "Club Social                 Bs 2 " + " \n " + "\n";
                                    break;
                                case 2:
                                    suma = suma + 3; //Precio Gauchitas
                                    cant = cant + "Gauchitas                   Bs 3" + " \n " + "\n"; 
                                    break;
                                case 3:
                                    suma = suma + 3; //Precio Moraditas
                                    cant = cant + "Moraditas                   Bs 3" + "\n" + "\n";
                                    break;
                                case 4:
                                    suma = suma + 3; //Precio Maria
                                    cant = cant + "Maria                       Bs 3" + "\n" + "\n";
                                    break;
                                case 5:
                                    suma = suma + 3; // Precio Oreo
                                    cant = cant + "Oreo                        Bs 3" + "\n" + "\n";
                                    break;
                                case 6:
                                    suma = suma + 5; // Precio Papas Fritas Peque�as
                                    cant = cant + "Papas Fritas Peque�o        Bs 5" + "\n" + "\n";
                                    break;
                                case 7:
                                    suma = suma + 5; //Precio Crackers
                                    cant = cant + "Crackers                    Bs 5" + "\n" + "\n";
                                    break;
                                case 8:
                                    suma = suma + 5; // Precio Chips Ahoy!
                                    cant = cant + "Chips Ahoy!                 Bs 5" + "\n" + "\n";
                                    break;
                                case 9:
                                    suma = suma + 5; //Precio Choco Soda
                                    cant = cant + "Choco Soda                  Bs 5" + "\n" + "\n";
                                    break;
                                case 10:
                                    suma = suma + 5;//Precio Wafers
                                    cant = cant + "Wafers                      Bs 5" + "\n" + "\n";
                                    break;
                                case 11:
                                    suma = suma + 7;//Precio Ducales
                                    cant = cant + "Ducales                     Bs 7" + "\n" + "\n";
                                    break;
                                case 12:
                                    suma = suma + 7;//Precio Choco Chip
                                    cant = cant + "Choco Chip                  Bs 7" + "\n" + "\n";
                                    break;
                                case 13:
                                    suma = suma + 9;//Precio Salvado
                                    cant = cant + "Salvado                     Bs 9" + "\n" + "\n";
                                    break;
                                case 14:
                                    suma = suma + 10;//Precio Champagne
                                    cant = cant + "Champagne                   Bs 10" + "\n" + "\n";
                                    break;
                                case 15:
                                    suma = suma + 10;//San Gabriel
                                    cant = cant + "San Gabriel                 Bs 10" + "\n" + "\n";
                                    break;
                                case 16:
                                    suma = suma + 15;//Papas Fritas Grande
                                    cant = cant + "Papas Fritas Grande         Bs 15" + "\n" + "\n";
                                    break;
                                case 17:
                                    suma = suma + 20;//Chocolate Bauducco
                                    cant = cant + "Chocolate Bauduco           Bs 20" + "\n" + "\n";
                                    break;
                                case 18:
                                    suma = suma + 20;//Praline
                                    cant = cant + "Praline                     Bs 20" + "\n" + "\n";
                                    break;
                                case 19:
                                    suma = suma + 20;//Chocolate Bom o Bom
                                    cant = cant + "Chocolate Bom o Bom         Bs 20" + "\n" + "\n";
                                    break;
                                case 20:
                                    suma = suma + 25;//Ferrari Integral 1kg
                                    cant = cant + "Ferrari Integral 1 kg       Bs 25" + "\n" + "\n";
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
                            Console.WriteLine("        CONCEPTO      " + "      IMPORTE");
                            Console.WriteLine("...........................................");
                            Console.WriteLine(cant);
                            Console.WriteLine("...........................................");
                            Console.WriteLine("        Total:               " + suma + " Bs");
                            Console.WriteLine();
                            Console.WriteLine("Emitodo por:  " + vendedor);
                            break;
                        }
                    case 3:
                        {
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
                                Console.WriteLine("18. Jab�n Bolivar ........................   5 Bs ");
                                Console.WriteLine("19. Esponja Scotch Brite .................  25 Bs ");
                                Console.WriteLine("20. Lavandina Mr.Flash ...................   1 Bs ");
                                Console.WriteLine("21. Alcohol en Gel OLA ...................  30 Bs ");
                                Console.WriteLine();
                                int menu3 = 0;
                                menu3=int.Parse(Console.ReadLine());
                                switch (menu3)
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
                                        cant = cant + "        Jab�n Bolivar             5 Bs" + "\n " + "\n";
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
                            Console.WriteLine("     CONCEPTO      " + "    IMPORTE");
                            Console.WriteLine("...........................................");
                            Console.WriteLine(cant);
                            Console.WriteLine("...........................................");
                            Console.WriteLine("        Total:               " + suma + " Bs");
                            Console.WriteLine();
                            Console.WriteLine("Emitodo por:  " + vendedor);
                        }
                        break;
                    case 4:
                        {
                            do
                            {
                                Console.WriteLine("La Seccion de Cereales ofrece lo siguiente:");
                                Console.WriteLine("");
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


                                int menu4 = 0;
                                menu4 = Convert.ToInt16(Console.ReadLine());
                                switch (menu4)
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
                            Console.WriteLine("        CONCEPTO      " + "      IMPORTE");
                            Console.WriteLine("...........................................");
                            Console.WriteLine(cant);
                            Console.WriteLine("...........................................");
                            Console.WriteLine("        Total:               " + suma + " Bs");
                            Console.WriteLine();
                            Console.WriteLine("Emitodo por:  " + vendedor);
                        }
                        break;
                    case 5:
                        break;
                    case 6:
                        {
                          do
                          { 
                            Console.WriteLine(".....Seccion Farmacia Ofrece Lo Siguiente.....");
                            Console.WriteLine("");
                            Console.WriteLine("1.-  Aspirina.....................Bs 2");
                            Console.WriteLine("2.-  Resfrianex Dia...............Bs 6");
                            Console.WriteLine("3.-  Resfrianex Noche.............Bs 6");
                            Console.WriteLine("4.-  Complejo B...................BS 20");
                            Console.WriteLine("5.-  Vitamina A...................Bs 2");
                            Console.WriteLine("6.-  Vitamina B...................Bs 2");
                            Console.WriteLine("7.-  Vitamina C...................Bs 2");
                            Console.WriteLine("8.-  Paracetamol..................Bs 3");
                            Console.WriteLine("9.-  Jarabe Para El Resfrio.......Bs 25");
                            Console.WriteLine("10.- Barbijos + Guantes...........Bs 5");
                            int menu6 = 0;
                            menu6 = int.Parse(Console.ReadLine());
                            switch (menu6)
                            {
                                case 1:
                                        suma = suma + 2;
                                        cant = cant + "     Aspirina             Bs 2 " + "\n" + "\n";
                                    break;
                                case 2:
                                        suma = suma + 6;
                                        cant = cant + "     Refrianex Dia        Bs 6" + "\n" + "\n";
                                    break;
                                case 3:
                                        suma = suma + 6;
                                        cant = cant + "     Refrianex Noche      Bs 6" + "\n" + "\n";
                                    break;
                                case 4:
                                        suma = suma + 20;
                                        cant = cant + "     Complejo B           Bs 20" + "\n" + "\n";
                                    break;
                                case 5:
                                        suma = suma + 2;
                                        cant = cant + "     Vitamina A           Bs 2" + "\n" + "\n";
                                    break;
                                case 6:
                                        suma = suma + 2;
                                        cant = cant + "     Vitamina B           Bs 2" + "\n" + "\n";
                                    break;
                                case 7:
                                        suma = suma + 2;
                                        cant = cant + "     Vitamina C           Bs 2" + "\n" + "\n";
                                    break;
                                case 8:
                                        suma = suma + 3;
                                        cant = cant + "   Paracetamol            Bs 3" + "\n" + "\n";
                                    break;
                                case 9:
                                        suma = suma + 25;
                                        cant = cant + "  Jarabe Para El Resfrio  Bs 25" + "\n" + "\n";
                                    break;
                                    case 10:
                                        suma = suma + 5;
                                        cant = cant + "  Barbijo + Guantes       Bs 5" + "\n" + "\n";
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
                            Console.WriteLine("        CONCEPTO      " + "      IMPORTE");
                            Console.WriteLine("...........................................");
                            Console.WriteLine(cant);
                            Console.WriteLine("...........................................");
                            Console.WriteLine("        Total:               " + suma + " Bs");
                            Console.WriteLine();
                            Console.WriteLine("Emitodo por:  " + vendedor);
                            Console.ReadKey();
                        }
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("No Selecciono Ninguna Opcion. Vuelva a intentarlo:");
                        break;
                }
                Console.WriteLine(suma + "Bs");
                Console.WriteLine("desea continuar....? Si o No...  ");
                respuesta = Console.ReadLine();
                Console.ReadKey();
            } while (respuesta != "no");
            Console.WriteLine(".....Gracias por su compra.....");
            Console.WriteLine("Bs" + suma);