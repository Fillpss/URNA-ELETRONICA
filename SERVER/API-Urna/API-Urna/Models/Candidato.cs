namespace API_Urna.Models
{
    public class Candidato
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? NomeVice { get; set; }
        public DateTime DataDoRegistro { get; set; }
        public string? Legenda { get; set; }
        public ICollection<Voto>? Votos { get; set; }

    }
}