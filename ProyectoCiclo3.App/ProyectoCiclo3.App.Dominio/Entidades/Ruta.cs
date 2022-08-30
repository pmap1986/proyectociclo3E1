namespace ProyectoCiclo3.App.Dominio.Entidades
{
    public class Ruta
    {
        public int id { get;set; }
        public Estacion origen { get; set; }
        public Estacion destino { get; set; }
        public int tiempo_estimado { get; set; }
    }
}