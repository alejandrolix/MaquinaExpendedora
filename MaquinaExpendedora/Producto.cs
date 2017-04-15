using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedora
{
    class Producto
    {
        #region Atributos y Propiedades

        private static int _ID;
        private String _Nombre;
        private String _Marca;
        private int _Cantidad;
        private float _Precio;

        public static int ID
        {
            get { return Producto._ID; }
            set { Producto._ID = value; }
        }
        public String Nombre
        {
            get { return this._Nombre; }
            set { this._Nombre = value; }
        }
        public String Marca
        {
            get { return this._Marca; }
            set { this._Marca = value; }
        }
        public int Cantidad
        {
            get { return this._Cantidad; }
            set { this._Cantidad = value; }
        }
        public float Precio
        {
            get { return this._Precio; }
            set { this._Precio = value; }
        }

        #endregion


        #region Métodos

        public static int ObtenerSiguienteID()
        {
            return Producto.ID + 1;
        }

        public void CambiarDatosProducto(String nombreIntroducido, String marcaIntroducida, int cantidadIntroducida, float precioIntroducido)
        {
            Producto.ID = Producto.ID;
            this.Nombre = nombreIntroducido;
            this.Marca = marcaIntroducida;
            this.Cantidad = cantidadIntroducida;
            this.Precio = precioIntroducido;

            Console.Clear();
            Console.WriteLine("Datos Cambiados.");
            System.Threading.Thread.Sleep(4000);

            Console.Clear();
        }

        public override string ToString()
        {
            return String.Format("Datos Producto \n Código: {0} \n Nombre: {1} \n Marca: {2} \n Precio: {3:F2} \n", Producto.ID, this.Nombre, this.Marca, this.Precio);
        }

        #endregion


        #region Constructor

        public Producto(String nombre, String marca, int cantidad, float precio)
        {
            Producto.ID = Producto.ObtenerSiguienteID();
            this.Nombre = nombre;
            this.Marca = marca;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }

        #endregion
    }
}
