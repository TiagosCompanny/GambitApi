namespace GambitApi.Entities
{
    public class Jogador
    {
        public Guid Codigo { get; set; }
        public int EquipeId { get; set; }
        public virtual Equipe Equipe { get; set; }
        public int LugarMesa { get; set; }
    }
}
