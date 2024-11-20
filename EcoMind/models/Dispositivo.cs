public class Dispositivo
{
    public int Id { get; set; } // Chave primária
    public string Nome { get; set; }
    public double ConsumoEstimado { get; set; }
    public string Tipo { get; set; }

    // Chave estrangeira para Usuario
    public int UsuarioId { get; set; }
    public Usuario Usuario { get; set; }

    // Relacionamento 1:N com Consumo
    public ICollection<Consumo> Consumos { get; set; }
}
