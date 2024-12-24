namespace GambitApi.Entities
{
    public class Jogador
    {
        public int Codigo { get; set; }
        public int EquipeId { get; set; }
        public virtual Equipe Equipe { get; set; }
    }
}
