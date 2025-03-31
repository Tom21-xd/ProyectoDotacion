namespace ProyectoDotacion.Models
{
    public class Dotacion
    {
        public int Id { get; set; }
        public int Cantiddad { get; set; }
        public int Fk_id_articulo { get; set; }
        public Articulo? ArticuloNav { get; set; }
        public int Fk_id_sede { get; set; }
        public Sede? SedeNav { get; set; }
        public int Fk_id_tipodotacion { get; set; }
        public TipoDotacion? TipoDotacionNav { get; set; }

    }
}
