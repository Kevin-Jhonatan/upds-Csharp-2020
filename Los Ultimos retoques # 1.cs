            string regist ;
            int carnet ;
            Console.WriteLine("Señor(a):");
            regist = Console.ReadLine();
            Console.WriteLine("NIT/CI. :");
            carnet = int.Parse(Console.ReadLine());
            
            
            
            
            
            // Proyecto N ° 1
            
            
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
                Console.WriteLine(" 6.- Seccion De Farmacia          ");
                Console.Write(" 3.- Seccion De Limpieza          ");
                Console.WriteLine(" 7.- Seccion Alimentos     ");
                Console.Write(" 4.- Seccion Frutas            ");
                Console.WriteLine(" 8.- Seccion Verduras             ");
                Console.WriteLine(" 5.- Seccion Licoreria            ");
                Console.WriteLine("");
                Console.WriteLine("                 9.- Terminar compra ");
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
                            Console.WriteLine("1.-  Club Social............ Bs 2");
                            Console.WriteLine("2.-  Gauchitas.............. Bs 3");
                            Console.WriteLine("3.-  Moraditas.............. Bs 3");
                            Console.WriteLine("4.-  Maria.................. Bs 3");
                            Console.WriteLine("5.-  Oreo................... Bs 3");
                            Console.WriteLine("6.-  Papas Frita pequeño.... Bs 5 ");
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
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            float suma = 0;
                            string respuesta;
                            do
                            {
                                Console.WriteLine("    ....Seccion de limpiesa....   ");
                                Console.WriteLine();
                                Console.WriteLine("1.-  Detergente OMO 1kl..................... Bs 15 ");
                                Console.WriteLine("2.-  Detergente Surf 1kl.................... Bs 15");
                                Console.WriteLine("3.-  Detergente liquido 1L.................. Bs 21");
                                Console.WriteLine("4.-  Suavisante de ropa 1l.................. Bs 20");
                                Console.WriteLine("5.-  jaboncillo Dove........................ Bs 4");
                                Console.WriteLine("6.-  Shampoo Sedal.......................... Bs 14");
                                Console.WriteLine("7.-  Crema dental Colgate................... Bs 10");
                                Console.WriteLine("8.-  Cepillo dental......................... Bs 15");
                                Console.WriteLine("9.-  Pack Escoba + lebantador de basura..... BS 25");
                                Console.WriteLine("10.- Antisarro OLA.......................... Bs 20");
                                Console.WriteLine("11.- Limpia Vidrio OLA...................... Bs 12");
                                Console.WriteLine("12.- Limpia Grasa OLA....................... Bs 15");
                                Console.WriteLine("13.- Antitranspirante Rexona................ Bs 15");
                                Console.WriteLine("14.- Antitraspirante Old Spice.............. Bs 12");
                                Console.WriteLine("15.- Lava Vajilla OLA....................... Bs 15");
                                Console.WriteLine("16.- Ambientador............................ BS 5 ");
                                Console.WriteLine("17.- Enjuage Bucal.......................... Bs 25");
                                Console.WriteLine("18.- Jabon Bolivar.......................... Bs 5");
                                Console.WriteLine("19.- Esponja................................ Bs 5");
                                Console.WriteLine("20.- Lavandina Mr.Flash .................... Bs 3");

                                int i1 = 0;
                                i1 = Convert.ToInt16(Console.ReadLine());
                                switch (i1)
                                {
                                    case 1:


                                        suma = suma + 23;   //precio omo

                                        break;
                                    case 2:
                                        suma = suma + 34;   //precio ace
                                        break;
                                    case 3:
                                        suma = suma + 89;
                                        break;
                                    case 4:
                                        suma = suma + 89;
                                        break;
                                    case 5:
                                        suma = suma + 16;
                                        break;
                                    case 6:
                                        suma = suma + 72;
                                        break;
                                    case 7:
                                        suma = suma + 89;
                                        break;
                                    case 8:
                                        suma = suma + 89;
                                        break;
                                    case 9:
                                        suma = suma + 16;
                                        break;
                                    case 10:
                                        suma = suma + 72;
                                        break;

                                }

                                Console.WriteLine(suma + "Bs");
                                Console.WriteLine("desea continuar....? Si o No...  ");
                                respuesta = Console.ReadLine();
                                Console.ReadKey();
                            } while (respuesta != "no");
                            Console.WriteLine("gracias por su compra");
                            Console.WriteLine(suma + "Bs");


                            DateTime fecha = DateTime.Now;
                            Console.WriteLine(fecha.ToString("dd/MM/yyyy"));
                            Console.WriteLine(fecha.ToString("hh:mm:ss"));


                            Console.ReadKey();
                        }
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
            