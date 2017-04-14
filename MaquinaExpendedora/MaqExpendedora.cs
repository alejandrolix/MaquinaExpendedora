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

        public void SacarProducto()
        {

        }

        public void AniadirProducto()
        {

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
