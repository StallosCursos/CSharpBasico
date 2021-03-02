using System;

class Cliente
{
    private DateTime _datanascimento;
    private bool _maiorIdade;

    public string Nome { get; set; }
    public string Cpf { get; set; }
    
    public bool MaiorIdade => _maiorIdade;

    public DateTime DataNacimento 
    {
        get => this._datanascimento;
        set 
        { 
           this._datanascimento = value;
           this._maiorIdade = DefinirMaioridade(value);
        } 
    }

    public Pagamento Pagamento { get; set; }

    private bool DefinirMaioridade(DateTime dataNascimento)
    {
        int idade = DateTime.Now.Year - dataNascimento.Year;

        // DayOfYear - Retorna um inteiro representando o dia do ano, exemplo 01/01/xxxx = 1
        if (DateTime.Now.DayOfYear < dataNascimento.DayOfYear)
        {
            idade = idade - 1;
        }

        
        return idade > 18;
    }
}
