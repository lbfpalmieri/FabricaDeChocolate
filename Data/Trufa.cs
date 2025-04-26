namespace FabricaDeChocolate.Data
{
    public class Trufa
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public decimal Preco { get; set; }

        // Chave estrangeira para Embalagem
        public int EmbalagemId { get; set; }

        // Propriedade de navegação
        public Embalagem Embalagem { get; set; } = new Embalagem();
    }
}
