namespace ProyectoDotacion.Models
{
    public class Institucion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CodigoDane { get; set; }
        public string Calendario { get; set; }
        public int Fk_id_municipio { get; set; }
        public Municipio? MunicipioNav { get; set; }
        public List<Sede> sedes { get; set; }
    }
}
