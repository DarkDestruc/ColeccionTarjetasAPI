namespace ColeccionTarjetasAPI.Models
{
    public class Persona
    {

        public int Id { get; set; }
        public string Nombres { get; set; }
        public ICollection<TarjetasDeCredito> TarjetasDeCreditos { get; set; }
        public object TarjetasDeCredito { get; internal set; }
    }
}
