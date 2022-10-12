using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace compañia_turismo
{
 class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Elige una la Compañia a volar\n" +
                "\n1.- Empresa Alas" +
                "\n2.- Empresa volar"
                );
            


            String s1 = null;
            s1 = Console.ReadLine();

            switch(s1)
            {
                case "1":
                Console.WriteLine("Seleccionaste empresa Alas");
                break;

                case "2":
                Console.WriteLine("Seleccionaste empresa Volar");
                break;

                default:
                    Console.WriteLine("No se ha seleccionado una opcion o no existe");
                    break;

                
            }
            String name = null;
            Console.WriteLine("Nombre del Usuario"
                );
            
            name = Console.ReadLine();
            Console.WriteLine("Bienvenido " + name);

            


            Console.WriteLine("Elige que Tipo de Cliente Es" +
                "\n1.- Estudiante" +
                "\n2.- Particular"
                );
            String usuario = null;
            usuario = Console.ReadLine();
            switch (usuario)
            {
                case "1":
                    Console.WriteLine("Seleccionaste Estudiante");
                    break;

                case "2":
                    Console.WriteLine("Seleccionaste Particular");
                    break;

                default:
                    Console.WriteLine("No se ha seleccionado una opcion o no existe");
                    break;


            }

            Console.WriteLine("Elige que Tipo de Temporada Es" +
                "\n1.- Baja" +
                "\n2.- Alta"
                );

            String temp = null;
            temp = Console.ReadLine();
            switch (temp)
            {
                case "1":
                    Console.WriteLine("Seleccionaste Temporada Baja");
                    break;

                case "2":
                    Console.WriteLine("Seleccionaste Temporada Alta");
                    break;

                default:
                    Console.WriteLine("No se ha seleccionado una opcion o no existe");
                    break;


            }

            int val;
            Console.WriteLine("Valor Tiquete"
            );

            val = int.Parse(Console.ReadLine());
            Console.WriteLine("tu tiquete es valor de " + val);






            int edad;
            Console.WriteLine("Ingrese la Edad"
                );
            

            edad = int.Parse(Console.ReadLine());
            if (edad >= 18 && usuario =="1" && s1 == "1" && temp == "1")
            {
                Console.WriteLine("Es mayor de Edad y no tiene descuento");
            } else
            {
                Console.WriteLine("Es menor de edad y tiene el 50% de Descuento");
            }
            if (edad >= 18 && usuario == "1" && s1 == "1")
            {
                Console.WriteLine("Tiene Descuento del 10% por ser estudiante, y volar con Alas y temporada baja");
            }
            else
            {
                Console.WriteLine("No Tiene Descuento del 10%, no es estudiante, no vuela con ALAS y no es temporada baja");
            }
            if (edad >= 60 && s1 == "2")
            {
                Console.WriteLine("Tiene Recargo de 10.000 por seguro de vida");
            }
            else
            {
                Console.WriteLine("No tiene Recargo por seguro de vida");
            }

            Console.WriteLine("el usuario es " + name);
            Console.WriteLine("valor del tiquete " + val);
            
            if (edad >= 18 && usuario == "1" && s1 == "1" && temp == "1")
            {
               Console.WriteLine(0);
            } else
            {
                Console.WriteLine("valor descuento 50 % " + val * 0.5);
            }
            if (edad >= 18 && usuario == "1" && s1 == "1")
            {
                Console.WriteLine("valor descuento 10% " + val * 0.10);
            }
            else
            {
                Console.WriteLine(0);
            }
            if (edad >= 60 && s1 == "2")
            {
                Console.WriteLine("valor Recargo " + val + 10000);
            }
            else
            {
                Console.WriteLine(0);
            }

            





            Console.ReadKey();


        }
        


    }
}
