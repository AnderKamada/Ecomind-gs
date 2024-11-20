using System.Collections.Generic;

public class Usuario
{
    public int Id { get; set; } // Chave primária
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Localizacao { get; set; }
    public DateTime DataRegistro { get; set; } = DateTime.Now;

    // Relacionamento 1:N com Dispositivo e GeracaoEnergia
    public ICollection<Dispositivo> Dispositivos { get; set; }
    public ICollection<GeracaoEnergia> GeracaoEnergia { get; set; }
}
