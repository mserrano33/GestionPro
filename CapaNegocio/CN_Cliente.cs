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
    public class CN_Cliente
    {
        private CD_Cliente objetoCD = new CD_Cliente();

        public DataTable Mostrarclient()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarCli(string nombre, string dni, string telefono, string direccion, string id_estado)
        {

            objetoCD.Insertar(nombre, dni, telefono, direccion, Convert.ToInt32(id_estado));
        }

        public void EditarProd(string nombre, string dni, string telefono, string direccion, string id_estado, string id_producto)
        {
            objetoCD.Editar(nombre, dni, telefono, direccion, Convert.ToInt32(id_estado));
        }

        public void EliminarPRod(string id_cliente)
        {

            objetoCD.Eliminar(Convert.ToInt32(id_cliente));
        }
    }
}
