public class Consumo
{
    public int Id { get; set; } // Chave primária
    public DateTime Data { get; set; }
    public double QuantidadeConsumida { get; set; }

    // Chave estrangeira para Dispositivo
    public int DispositivoId { get; set; }
    public Dispositivo Dispositivo { get; set; }
}
