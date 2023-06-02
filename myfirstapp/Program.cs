namespace CalculadoraBasica
{
    class Program
    { 
        static void Main (string[] args)
          {
            // DECLARACION DE VARIABLES
           int opcn, Resp;
           double Num1, Num2, Total;

           do
           {
                Console.Clear();
                //MENU
                Console.WriteLine("OPERACIONES BASICA");
                Console.WriteLine("---------------------------");
                Console.WriteLine("");
                Console.WriteLine("1.-SUMA");
                Console.WriteLine("2.-RESTA");
                Console.WriteLine("3.-MULTIPLICACION");
                Console.WriteLine("4.-DIVISION");
                Console.WriteLine("----------------------------");




                //OPCIONES
                    Console.WriteLine("Que opcion deseas? ");
                    opcn = Convert.ToInt32(Console.ReadLine());

                    //CASE

                    switch (opcn)
                    {
                  case 1:
                       Console.Clear();
                       Console.WriteLine("1.-SUMA");
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("Captura un numero");
                        Num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Captura otro numero");
                        Num2 = Convert.ToDouble(Console.ReadLine());

                        Total = Num1 + Num2;


                      Console.WriteLine("La SUMA total es: "+Total);


                      //PAUSA
                      Console.ReadLine();
                      break;

                      case 2:
                       Console.Clear();
                       Console.WriteLine("2.-RESTA");
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("Captura un numero");
                        Num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Captura otro numero");
                        Num2 = Convert.ToDouble(Console.ReadLine());

                        Total = Num1 - Num2;


                      Console.WriteLine("La RESTA total es: "+Total);


                      //PAUSA
                      Console.ReadLine();
                      break;

                      case 3:
                       Console.Clear();
                       Console.WriteLine("3.-MULTIPLICACION");
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("Captura un numero");
                        Num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Captura otro numero");
                        Num2 = Convert.ToDouble(Console.ReadLine());

                        Total = Num1 * Num2;


                      Console.WriteLine("La MULTIPLICACION total es: "+Total);

                    
                      //PAUSA
                      Console.ReadLine();
                      break;

                      case 4:
                       Console.Clear();
                       Console.WriteLine("1.-DIVISION");
                        Console.WriteLine("----------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("Captura un numero");
                        Num1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Captura otro numero");
                        Num2 = Convert.ToDouble(Console.ReadLine());

                        Total = Num1 / Num2;


                      Console.WriteLine("La DIVISION total es: "+Total);


                      //PAUSA
                      Console.ReadLine();
                      break;

                default:

                    Console.WriteLine("ERROR. Intentalo de nuevo");

                 //PAUSA
                      Console.ReadLine();
                 break;
                }

                Console.WriteLine("0 Cero para salir del programa, cualquier otro numero para continuar");
                Resp = Convert.ToInt32(Console.ReadLine());

            } while (Resp != 0);
    }   }
    
}