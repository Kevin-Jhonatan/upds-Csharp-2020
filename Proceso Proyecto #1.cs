 int menu1 = 0;
            string regist;
            int total, carnet, a = 10, b = 10, c = 10, d, e, f, g, h, i;
            while (menu1 != 5)
            {
                // Opciones del Menu Principal :
                Console.WriteLine("                     ...\\ Bienvenido A Tieda ...Las Islas... /...");
                Console.WriteLine("");
                Console.WriteLine(" Seleccione Una Seccion De Compra  : ");
                Console.WriteLine("");
                Console.WriteLine(" 1.- Seccion Resfrescos           ");
                Console.Write(" 2.- Seccion Galletas          ");
                Console.WriteLine(" 6.- Seccion De Limpieza          ");
                Console.Write(" 3.- Seccion Farmacia          ");
                Console.WriteLine(" 7.- Seccion Alimentos     ");
                Console.Write(" 4.- Seccion Frutas            ");
                Console.WriteLine(" 8.- Seccion Verduras             ");
                Console.WriteLine(" 5.- Seccion Licoreria            ");
                Console.WriteLine("");
                Console.Write("                 9.- Terminar compra ");
                menu1 = int.Parse(Console.ReadLine());
                switch (menu1)
                {
                    case 1:
                        {
                            Console.WriteLine("La Seccion De Refrescos Ofrece Lo Siguiente :");
                            Console.WriteLine("1.- 7 Up .....3 Lts.   Bs 10 ");
                            Console.WriteLine("2.- Pepsi.....3 Lts.   Bs 10 ");
                            Console.WriteLine("3.- Ades .....2 Lts.   Bs 10 ");


                            c = int.Parse(Console.ReadLine());
                            total = a + b + c;
                            Console.WriteLine(total);
                            break;
                        }
                    case 2:
                        { 
                            Console.WriteLine("La Seccion De Galletas Ofrece Lo Siguiente  :");
                            Console.WriteLine("1.-  Club Social............Bs 2");
                            Console.WriteLine("2.-  Gauchitas..............Bs 3");
                            Console.WriteLine("3.-  Moraditas..............Bs 3");
                            Console.WriteLine("4.-  Maria..................Bs 3");
                            Console.WriteLine("5.-  Oreo...................Bs 3");
                            Console.WriteLine("6.-  Papas Frita pequeño....Bs 5 ");
                            Console.WriteLine("7.-  CracKers...............Bs 5");
                            Console.WriteLine("8.-  Chips Ahoy!............Bs 5");
                            Console.WriteLine("9.-  Choco Soda.............Bs 5");
                            Console.WriteLine("10.- Wafers.................Bs 5");
                            Console.WriteLine("11.- Ducales................Bs 7");
                            Console.WriteLine("12-  Choco Chip.............Bs 7.50");
                            Console.WriteLine("13.- Salvado................Bs 9.50");
                            Console.WriteLine("14.- Champagne..............Bs 10");
                            Console.WriteLine("15.- San Gabriel............Bs 10.50");
                            Console.WriteLine("16.- Papas Fritas Grande....Bs 15");
                            Console.WriteLine("17.- Chocolate Bauducco.....Bs 20");
                            Console.WriteLine("18.- Praline................Bs 20");
                            Console.WriteLine("29.- Chocolate Bom o bom....Bs 20");
                            Console.WriteLine("20.- Ferrari Integral 1 kg..Bs 25");
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    default:
                        Console.WriteLine("No Selecciono Ninguna Opcion. Vuelva a intentarlo:");
                        break;
                }
            }