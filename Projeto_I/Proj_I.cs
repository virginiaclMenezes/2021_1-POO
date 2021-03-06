using System;

//Classe principal
class MainClass {
  public static void Main () {
    Curso c1 = new Curso(1, "TADS");
    Curso c2 = new Curso(2, "REDES"); 
    Console.WriteLine (c1);
    Console.WriteLine (c2);

    Aluno a1 = new Aluno(1, "Joana", "Rua um", 900000000);
    Aluno a2 = new Aluno(2, "Virgínia", "Rua dois", 900000000);
    Aluno a3 = new Aluno(3, "Christian", "Rua três", 900000000);
    Aluno a4 = new Aluno(4, "João", "Rua quatro", 900000000);
    
    Console.WriteLine (a1);
    Console.WriteLine (a2);
    Console.WriteLine (a3);
    Console.WriteLine (a4);
  }
}

//Classe de Cursos
class Curso{
  private int id;
  private string descricao;

  public Curso(int id, string descricao){
    this.id = id;
    this.descricao = descricao;
  }

  public void SetId(int id){
    this.id = id;
  }

  public void SetDescricao(string descricao){
    this.descricao = descricao;
  }

  public int GetId(){
    return id;
  }

  public string GetDescricao(){
    return descricao;
  }

  public override string ToString(){
    return id + " - " + descricao;
  }
}

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