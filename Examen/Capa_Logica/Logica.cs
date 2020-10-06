using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using Capa_Datos;

namespace Capa_Logica
{
    public class Logica
    {
        Sentencias sn = new Sentencias(); //llamamos a clase sentencias
        public OdbcDataReader insertar_empleado(string[] dato) 
        {
            return sn.insertar_empleado(dato);
        }
        public OdbcDataReader modificar_empleado(string[] dato)
        {
            return sn.modificar_empleado(dato);
        }
        public OdbcDataReader eliminar_empleado(string[] dato)
        {
            return sn.eliminar_empleado(dato);
        }
        public OdbcDataReader eliminar_concepto(string[] dato)
        {
            return sn.eliminar_concepto(dato);
        }
        public OdbcDataReader insertar_concepto(string[] dato)
        {
            return sn.insertar_concepto(dato);
        }
        public OdbcDataReader modificar_concepto(string[] dato)
        {
            return sn.modificar_concepto(dato);
        }
        public OdbcDataReader consultar(string tabla)
        {
            return sn.consulta(tabla);
        }
        public OdbcDataReader insertar_encabezado(string[] dato)
        {
            return sn.insertar_encabezado(dato);
        }
        public OdbcDataReader insertar_detalle(string[] dato)
        {
            return sn.insertar_encabezado(dato);
        }
    }
}
