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