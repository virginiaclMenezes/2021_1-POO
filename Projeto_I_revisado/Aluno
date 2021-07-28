//Classe Aluno
class Aluno{
  private int id;
  private string nome;
  private string endereco;
  private int telefone;

  public Aluno(int id, string nome, string endereco, int telefone){
    this.id = id;
    this.nome = nome;
    this.endereco = endereco;
    this.telefone = telefone > 0 ? telefone : 0;
  }

  public void SetId(int id){
    this.id = id;
  }

  public void SetNome(string nome){
    this.nome = nome;
  }

  public void SetEndereco(string endereco){
    this.endereco = endereco;
  }

  public void SetTelefone(int telefone){
    this.telefone = telefone > 0 ? telefone : 0;
  }

  public int GetId(){
    return id;
  }

  public string GetNome(){
    return nome;
  }

  public string GetEndereco(){
    return endereco;
  }

  public int GetTelefone(){
    return telefone;
  }

  public override string ToString(){
    return id + " - " + "Aluno(a): " +nome + " - Endereço: " + endereco + " - Telefone: " + telefone.ToString("0");
  }
}
