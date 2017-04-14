using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedora
{
    class MaqExpendedora
    {
        #region Atributos y Propiedades

        private String _Marca;
        private String _Modelo;
        private String _TelefonoAverias;
        private List<Producto> _Productos;

        public String Marca
        {
            get { return this._Marca; }
            set { this._Marca = value; }
        }
        public String Modelo
        {
            get { return this._Modelo; }
            set { this._Modelo = value; }
        }
        public String TelefonoAverias
        {
            get { return this._TelefonoAverias; }
            set { this._TelefonoAverias = value; }
        }
        public List<Producto> Productos
        {
            get { return this._Productos; }
            set { this._Productos = value; }
        }

        #endregion


        #region Métodos

        public void CambiarDatosMaquina()
        {

        }

        public void SacarProducto(Producto producto)
        {
            float precioIntroducido, cambioDinero;

            Console.Clear();
            Console.Write("Introduce " + producto.Precio + " euros: ");
            precioIntroducido = float.Parse(Console.ReadLine());

            cambioDinero = producto.Precio - precioIntroducido;

            Console.Clear();
            Console.WriteLine("Por favor, retira el producto de la bandeja.");
            System.Threading.Thread.Sleep(4000);

            producto.Precio = producto.Precio - 1;            

            Console.Clear();

            if (cambioDinero > 0.00)
            {
                Console.WriteLine("Recoje el cambio.");
                Console.WriteLine("Cambio: " + cambioDinero + " euros");
            }
            Console.Clear();
        }

        public void AniadirProducto(String nombre, String marca, int cantidad, float precio)
        {            
            this.Productos.Add(new Producto( nombre, marca, cantidad, precio));

            if (this.Productos.Count > 2)
            {
                this.Productos.Sort();
            }
            
            Console.Clear();
            Console.WriteLine("Producto Añadido.");
            System.Threading.Thread.Sleep(4000);

            Console.Clear();
        }

        #endregion


        #region Constructores

        public MaqExpendedora(String marca, String modelo, String telefonoAverias, List<Producto> productos)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.TelefonoAverias = telefonoAverias;
            this.Productos = new List<Producto>();
        }

        #endregion
    }
}
