namespace ColeccionTarjetasAPI.Models
{
    public class TarjetasDeCredito
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Banco { get; set; }
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
    }
}
