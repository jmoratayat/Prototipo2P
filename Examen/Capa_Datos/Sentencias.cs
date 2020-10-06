using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Capa_Datos
{
   public class Sentencias
    {
        Conexion cn = new Conexion(); //crea objeto
        OdbcCommand com; //variable que ejecute querys
       public OdbcDataReader insertar_empleado(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO empleado Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "');"; //Solo me difica consulta, lo demas queda igual, es base para modificar, insertar y eliminar
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err) {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader modificar_empleado(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE empleado SET nombre_empleado = '"+datos[1]+"', codigo_puesto = '"+datos[2]+ "', codigo_departamento = '" + datos[3] + "' , sueldo_empleado = '" + datos[4] + "', estatus_empleado = '" + datos[5] + "'WHERE codigo_empleado='" + datos[0]+"';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader modificar_concepto(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE concepto SET nombre_concepto = '" + datos[1] + "', efecto_concepto = '" + datos[2] + "', estatus_concepto = '" + datos[3] + "'  WHERE codigo_concepto='" + datos[0] + "';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader eliminar_concepto(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE concepto SET  estatus_concepto = '"+ 0 + "'  WHERE codigo_concepto='" + datos[0] + "';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader eliminar_empleado(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "UPDATE empleado SET nombre_empleado = '" + datos[1] + "', codigo_puesto = '" + datos[2] + "', codigo_departamento = '" + datos[3] + "' , sueldo_empleado = '" + datos[4] + "', estatus_empleado = '" + 0 + "'WHERE codigo_empleado='" + datos[0] + "';"; // modificar por id
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader insertar_concepto(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO concepto Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[3] + "');"; //Solo me difica consulta, lo demas queda igual, es base para modificar, insertar y eliminar
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader insertar_encabezado(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO nominae Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "');"; //Solo me difica consulta, lo demas queda igual, es base para modificar, insertar y eliminar
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader insertar_detalle(string[] datos) //funcion para insertar en db
        {
            try
            {
                cn.conexion();
                string consulta = "INSERT INTO nominad Values ('" + datos[0] + "','" + datos[1] + "','" + datos[2] + "','" + datos[2] + "');"; //Solo me difica consulta, lo demas queda igual, es base para modificar, insertar y eliminar
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader consulta(string tabla) 
        {
                try 
            {
                cn.conexion();
                string consulta = "SELECT * FROM "+tabla+";"; 
                com = new OdbcCommand(consulta, cn.conexion());
                OdbcDataReader respuesta = com.ExecuteReader();
                return respuesta;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
    }
}
