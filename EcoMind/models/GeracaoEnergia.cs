public class GeracaoEnergia
{
    public int Id { get; set; } // Chave primária
    public DateTime Data { get; set; }
    public double QuantidadeGerada { get; set; }
    public string TipoFonte { get; set; }

    // Chave estrangeira para Usuario
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }
}
