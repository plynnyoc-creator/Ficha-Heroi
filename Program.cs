int vida = 100;
int moedas = 20;
int nivel = 1;

System.Console.WriteLine("Qual o nome do Heroi?");
string nome = Console.ReadLine()!;

Console.Clear();
System.Console.WriteLine(" **FICHA** \n");
System.Console.WriteLine($" Heroi: {nome}\n Vida atual: {vida} Pontos\n Quantidade de moedas: {moedas} \n Nivel atual: {nivel}");