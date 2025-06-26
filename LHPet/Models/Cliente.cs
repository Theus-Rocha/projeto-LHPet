namespace LHPet.Models;

public class Cliente
{
    public int Id { get; set; }
    public string nome { get; set; }
    public string cpf { get; set; }
    public string email { get; set; }
    public string paciente { get; set; }

    public Cliente(int id, string nome, string cpf, string email, string paciente)
    {
        this.Id = id;
        this.nome = nome;
        this.cpf = cpf;
        this.email = email;
        this.paciente = paciente;
    }
}