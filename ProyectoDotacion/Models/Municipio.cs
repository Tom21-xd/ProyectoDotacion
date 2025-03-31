namespace ProyectoDotacion.Models
{
    public class Municipio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string latitud { get; set; }
        public string longitud { get; set; }
        public List<Institucion> instituciones { get; set; }
    }
}
