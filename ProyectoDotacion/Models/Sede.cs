namespace ProyectoDotacion.Models
{
    public class Sede
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CodigoDane { get; set; }
        public string Zona { get; set; }
        public string Direccion { get; set; }
        public string longitud { get; set; }
        public string latitud { get; set; }
        public int Fk_id_institucion { get; set; }
        public Institucion? InstitucionNav { get; set; }
    }
}
