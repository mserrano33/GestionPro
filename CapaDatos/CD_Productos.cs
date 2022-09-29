using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Productos
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar() { 
       
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
            
        }

        public void Insertar(string nombre,string desc,string marca,double precio,double preciocosto, int stock ) {
            //PROCEDIMNIENTO
            
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsetarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre",nombre);
            comando.Parameters.AddWithValue("@descrip",desc);
            comando.Parameters.AddWithValue("@Marca",marca);
            comando.Parameters.AddWithValue("@precio",precio);
            comando.Parameters.AddWithValue("@preciocosto", preciocosto);
            comando.Parameters.AddWithValue("@stock",precio);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        
        }

        public void Editar(string nombre, string desc, string marca, double precio,double preciocosto, int stock,int id_producto)
        {
            
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@Marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@preciocosto", preciocosto);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@id_producto",id_producto);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Eliminar(int id) {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_producto",id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

    }
}
