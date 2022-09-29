using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Productos
    {
        private CD_Productos objetoCD = new CD_Productos();

        public DataTable MostrarProd() {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarPRod ( string nombre,string desc,string marca,string precio,string preciocosto, string stock){

            objetoCD.Insertar(nombre,desc,marca,Convert.ToDouble(precio), Convert.ToDouble(preciocosto), Convert.ToInt32(stock));
    }

        public void EditarProd(string nombre, string desc, string marca, string precio,string preciocosto, string stock,string id_producto)
        {
            objetoCD.Editar(nombre, desc, marca, Convert.ToDouble(precio), Convert.ToDouble(preciocosto), Convert.ToInt32(stock),Convert.ToInt32(id_producto));
        }

        public void EliminarPRod(string id_producto) {

            objetoCD.Eliminar(Convert.ToInt32(id_producto));
        }

    }
}
