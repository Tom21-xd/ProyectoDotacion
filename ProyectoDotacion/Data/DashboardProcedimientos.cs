using System.Configuration;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ProyectoDotacion.Models;

namespace ProyectoDotacion.Data
{
    public class DashboardProcedimientos
    {
        public Conexion cn=new Conexion();

        public List<Grafica> getZonas()
        {
            DataTable dt = cn.EjecutarConsulta("GetSedesPorZona");
            List<Grafica> zonaCantidas = new List<Grafica>();
            foreach (DataRow dr in dt.Rows)
            {
                Grafica a = new Grafica();
                a.nombre = dr["Zona"] + "";
                a.cantidad = int.Parse(dr["Cantidad"] + "");
                zonaCantidas.Add(a);
                
            }
            return zonaCantidas;
        }

        public List<Grafica> getCantidadSede()
        {
            DataTable dt = cn.EjecutarConsulta("GetCantidadSede");
            List<Grafica> graficas = new List<Grafica>();
            foreach (DataRow item in dt.Rows)
            {
                Grafica a = new Grafica();
                a.cantidad = int.Parse(item["Cantidad"] + "");
                a.nombre = item["NOMBRE_INSTITUCION"] + "";
                graficas.Add(a);
            }
            return graficas;
        }
        public List<Grafica> getinstitucionarticulo(){

            DataTable dt = cn.EjecutarConsulta("GetInstitucionesArticulos");
            List<Grafica> articulos = new List<Grafica>();
            foreach(DataRow i in dt.Rows)
            {
                Grafica arti=new Grafica();
                arti.nombre = i["NOMBRE_INSTITUCION"] + "";
                arti.cantidad = int.Parse(i["CantidadTotalArticulos"] + "");
                articulos.Add(arti);
            }
            return articulos;
        }
    }
}
