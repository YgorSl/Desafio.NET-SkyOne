Console.WriteLine("Bem vindo ao Teste 02, para iniciarmos qual é o seu Nome?");
string nome = Console.ReadLine();
double qtdNota = 0;
double nota = 0;
double total = 0;
calcularNota();

void calcularNota()
{   
    Console.WriteLine($"{nome} por favor nos informe qual foi sua nota na prova");
    nota = Convert.ToDouble(Console.ReadLine());
    qtdNota++;
    total += nota;
    double media  = total / qtdNota;
    Console.WriteLine($"Nome = {nome}\nQuantidade de Provas: {qtdNota}\nTotal de Nota{total}\nsua média é de {media}\n");

    calcularNota();
}
