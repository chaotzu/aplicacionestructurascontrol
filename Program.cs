using System;

namespace aplicacionestructurascontrol
{
    class Program
    {
        static void Main(string[] args)
        {

            

                int menu = 0;
                ListaNumeros milista = new ListaNumeros();
                bool validar, terminarPrograma;
                Random valorGenerado = new Random();
                //            
                do
                {
                   terminarPrograma = false;
                   Console.WriteLine("Lista de n{umeros" +
                                      "\n 1.Crear lista." +
                                      "\n 2.Ordenar lista." +
                                      "\n 3.Sumar lista." +
                                      "\n 4.Restar lista." +
                                      "\n 5.Imprimir lista." +
                                      "\n 6.Salir.\n");
              do
              {
                  do
                  {
                      Console.Write("Elija Opción: ");
                      validar = int.TryParse(Console.ReadLine(), out menu);
                  } while (!validar);
              } while (menu < 1 || menu > 6);
              
              if (menu != 6)
              {
                   switch (menu)
                   {
                       case 1:
                               Console.WriteLine("Ingresa los números de la lista separados por un espacio");
                               string[] lista = Console.ReadLine().Split();
                               milista.setNumeros(lista);
                               Console.WriteLine("Lista creada con éxito");
                               Console.WriteLine("Oprime tecla para continuar");
                                Console.ReadKey();

                         ; break;
                       case 2:
                            milista.ordenar();
                             Console.WriteLine("Lista ordenada con éxito");
                             Console.WriteLine("Oprime tecla para continuar");
                             Console.ReadKey();
                             ; break;
                       case 3:

                            Console.WriteLine("La suma es: " + milista.sumar());
                            Console.WriteLine("Oprime tecla para continuar");

                            Console.ReadKey();
                            ; break;
                      case 4:
                           
                           Console.WriteLine("La resta es: " + milista.restar());

                           Console.WriteLine("Oprime tecla para continuar");

                            Console.ReadKey();
                            ; break;
                      case 5:
                          milista.imprimirLista();
                          Console.WriteLine("Oprime tecla para continuar");

                          Console.ReadKey();
                          ; break;
                    }
              }                
              else
              {
                  terminarPrograma = true;
              }
              Console.Clear();
             } while (terminarPrograma == false);
        
 

        }
    }
}
