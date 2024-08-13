namespace lupafinance;

public class Cliente 
{ 
    string nome;
    Int64 id;
    string email;
    string Telefone;
    string CPF;

    public void SetNome(string nome)
    {
        this.nome = nome ;
    }
    public string GetNome()
    {
        return nome;
    }
    
    public void Setemail(string email)
    {
        this.email = email ;
    } 

    public string Getemail()
    {
        return email;
    }


}