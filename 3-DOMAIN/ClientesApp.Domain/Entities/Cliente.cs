namespace ClientesApp.Domain.Entities;
/// <summary>
/// Modelo de entidade de domínio
/// </summary>
public class Cliente
{
    public Guid Id { get; set; }
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public string? Cpf { get; set; }
}