namespace apifuncionario.Models;

public class Funcionario
{
    public string? Nome {get;set;}
    public int FuncionarioId {get;set;}
    public int SetorId {get;set;}
    public virtual Setor? Setor {get;set;}
}
