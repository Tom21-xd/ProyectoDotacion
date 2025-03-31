using ProyectoDotacion.Models;
using System.Data;

namespace ProyectoDotacion.Data
{
    public class HomeProcedimientos
    {
        public Conexion cn = new Conexion();

        public List<Sede> GetSedes()
        {

            DataTable datos = cn.EjecutarConsulta("GetSedes");
            List<Sede> sedes = new List<Sede>();
            foreach (DataRow fila in datos.Rows)
            {
                Sede sede = new Sede();
                sede.Id = int.Parse(fila["ID_SEDE"].ToString());
                sede.Nombre = fila["NOMBRE_SEDE"].ToString();
                sede.CodigoDane = fila["CODIGODANE_SEDE"].ToString();
                sede.Zona = fila["ZONA_SEDE"].ToString();
                sede.Direccion = fila["DIRECCION_SEDE"].ToString();
                sede.longitud = fila["LONGITUD_SEDE"].ToString();
                sede.latitud = fila["LATITUD_SEDE"].ToString();
                sede.Fk_id_institucion = int.Parse(fila["FK_ID_INSTITUCION"].ToString());
                sede.CantidadArticulos = int.Parse(fila["CANTIDAD_ARTICULOS"].ToString());
                sedes.Add(sede);
            }
            return sedes;
        }

        public List<Municipio> GetMunicipiosIntitucion()
        {
            DataTable dt = cn.EjecutarConsulta("GetMunicipiosInstitucion");
            List<Municipio> municipios = new List<Municipio>();
            foreach (DataRow fila in dt.Rows)
            {
                Municipio municipio = new Municipio();
                municipio.Id = int.Parse(fila["ID_MUNICIPIO"].ToString());
                municipio.Nombre = fila["NOMBRE_MUNICIPIO"].ToString();
                municipio.latitud = fila["LATITUD_MUNICIPIO"].ToString();
                municipio.longitud = fila["LONGITUD_MUNICIPIO"].ToString();
                List<Institucion> instituciones = new List<Institucion>();
                var i = (fila["INSTITUCIONES"] + "").Split(";");
                foreach (var item in i)
                {
                    Institucion institucion = new Institucion();
                    var j = item.Split(":");
                    institucion.Id = int.Parse(j[0]);
                    institucion.Nombre = j[1];
                    instituciones.Add(institucion);
                }
                municipio.instituciones = instituciones;
                municipios.Add(municipio);
            }
            return municipios;
        }


    }
}
