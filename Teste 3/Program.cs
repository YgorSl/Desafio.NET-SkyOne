Console.WriteLine("Bem Vindo ao Teste 03");
calcularMedia();

void calcularMedia()
{
    Console.WriteLine("Informe o nome do Aluno:");

    string nome = Console.ReadLine();
    Console.WriteLine($"Qual foi a nota do primeiro semestre do aluno {nome}");
    double nota1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"Qual foi a nota do segundo semestre do aluno {nome}");
    double nota2 = Convert.ToDouble(Console.ReadLine());

    double media = (nota1 + nota2) / 2;
    Console.WriteLine($"Nome do aluno: {nome}");
    Console.WriteLine($"Média = {media}");

    if (media > 6)
    {
        Console.WriteLine("O Aluno foi: Aprovado\n");
    }
    else Console.WriteLine("O aluno foi Reprovado\n");
    calcularMedia();
}