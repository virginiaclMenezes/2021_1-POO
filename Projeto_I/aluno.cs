using System;
//Classe de Alunos
class Aluno{
  private int id;
  private string descricao;
  private string endereco;
  private int telefone;

  public Aluno(int id, string descricao, string endereco, int telefone){
    this.id = id;
    this.descricao = descricao;
    this.endereco = endereco;
    this.telefone = telefone > 0 ? telefone : 0;
  }

  public void SetId(int id){
    this.id = id;
  }

  public void SetDescricao(string descricao){
    this.descricao = descricao;
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

  public string GetDescricao(){
    return descricao;
  }

  public string GetEndereco(){
    return endereco;
  }

  public int GetTelefone(){
    return telefone;
  }

  public override string ToString(){
    return id + " - " + descricao + " - Endereço: " + endereco + " - Telefone: " + telefone.ToString("0");
  }
}