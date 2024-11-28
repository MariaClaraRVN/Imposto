using System;

class Program {
  public static void Main (string[] args) {
    int op;
    double valor;
    double ipva;
    Console.WriteLine("1 - Carro");
    Console.WriteLine("2 - Moto");
    Console.WriteLine("3 - Caminhão");
    Console.WriteLine("Digite a opção desejada.");
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
    case 1:
      Console.WriteLine("Insira o valor do carro: ");
      valor = double.Parse(Console.ReadLine());
      ipva = (valor * 6) / 100;
      Console.WriteLine("O valor do IPVA a ser pago é de: " + "R$" + ipva);
      break;
    case 2:
      Console.WriteLine("Insira o valor da moto: ");
      valor = double.Parse(Console.ReadLine());
      ipva = (valor * 8) / 100;
      Console.WriteLine("O valor do IPVA a ser pago é de: " + "R$" + ipva);
      break;
    case 3:
      Console.WriteLine("");
      valor = double.Parse(Console.ReadLine());
      ipva = (valor * 3) / 100;
      Console.WriteLine("O valor do IPVA a ser pago é de: " + "R$" + ipva);
      break;
    default:
      Console.WriteLine("?");
      break;
    }
  }
}