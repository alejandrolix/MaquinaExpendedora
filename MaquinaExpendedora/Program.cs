﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedora
{
    class Program
    {
        static void AniadirProducto(MaqExpendedora maquina)
        {
            String nombreIntroducido = "", marcaIntroducida = "";
            int cantidadIntroducida = 0;
            float precioIntroducido = 0.00f;
            Boolean repetirNombre = true, repetirMarca = true, repetirCantidad = true, repetirPrecio = true;

            while (repetirNombre)
            {
                Console.Clear();
                Console.Write("Introduce el nombre del producto: ");
                nombreIntroducido = Console.ReadLine();

                if (nombreIntroducido == "")
                {
                    Console.Clear();
                    Console.WriteLine("Error, tienes que introducir un nombre.");
                    System.Threading.Thread.Sleep(4000);
                }
                else
                {
                    repetirNombre = false;
                }
            }

            while (repetirMarca)
            {
                Console.Clear();
                Console.Write("Introduce la marca del producto: ");
                marcaIntroducida = Console.ReadLine();

                if (marcaIntroducida == "")
                {
                    Console.Clear();
                    Console.WriteLine("Error, tienes que introducir una marca.");
                    System.Threading.Thread.Sleep(4000);
                }
                else
                {
                    repetirMarca = false;
                }
            }

            while (repetirCantidad)
            {
                Console.Clear();
                Console.Write("Introduce la cantidad del producto: ");
                cantidadIntroducida = int.Parse(Console.ReadLine());

                if (cantidadIntroducida <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Error, tienes que introducir una cantidad.");
                    System.Threading.Thread.Sleep(4000);
                }
                else
                {
                    repetirCantidad = false;
                }
            }

            while (repetirPrecio)
            {
                Console.Clear();
                Console.Write("Introduce el precio del producto: ");
                precioIntroducido = float.Parse(Console.ReadLine());

                if (precioIntroducido <= 0.00)
                {
                    Console.Clear();
                    Console.WriteLine("Error, tienes que introducir un precio.");
                    System.Threading.Thread.Sleep(4000);
                }
                else
                {
                    repetirPrecio = false;
                }
            }

            maquina.AniadirProducto(nombreIntroducido, marcaIntroducida, cantidadIntroducida, precioIntroducido);
        }

        static void SacarProducto(MaqExpendedora maquina)
        {
            Boolean repetirListado = true;
            int codigoIntroducido;            

            while (repetirListado)
            {
                Console.Clear();
                Console.WriteLine("Productos: \n");

                for (int i = 0; i < maquina.Productos.Count; i++)
                {
                    if (maquina.Productos[i].Cantidad > 0)
                    {
                        Console.WriteLine(maquina.Productos[i]);
                        Console.WriteLine("\n \n");
                    }                    
                }

                Console.Write("Introduce el código del producto: ");
                codigoIntroducido = int.Parse(Console.ReadLine());

                if (codigoIntroducido >= 1 && codigoIntroducido <= maquina.Productos.Count)
                {
                    repetirListado = false;                    

                    for (int i = 0; i < maquina.Productos.Count; i++)
                    {
                        if (codigoIntroducido == Producto.ID)
                        {                            
                            maquina.SacarProducto(maquina.Productos[i]);                          
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Error, no has introducido el número correcto.");
                    System.Threading.Thread.Sleep(5000);
                }
            }
        }

        static void Main(string[] args)
        {
            try
            {
                MaqExpendedora maquina = new MaqExpendedora("ProductKey", "HSA-23", "542396587", new List<Producto>());
                AniadirProducto(maquina);
                SacarProducto(maquina);






                Console.ReadKey();
            }
            catch (FormatException)
            {
                                
            }
        }
    }
}
