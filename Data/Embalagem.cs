using FabricaDeChocolate.Data;

public class Embalagem
{
    public int Id { get; set; }
    public string Tamanho { get; set; } = string.Empty;
    public string Cor { get; set; } = string.Empty;
    public int QtdDisponivel { get; set; }
    public int QtdMinima { get; set; }
    public ICollection<Trufa> Trufas { get; set; } = new List<Trufa>();
}