namespace API_Urna.Models
{
    public class Voto
    {
        public int Id { get; set; }
        public DateTime DataDoVoto { get; set; }

        public int CandidatoId { get; set; }
        public Candidato? Candidato { get; set; }
    }
}
