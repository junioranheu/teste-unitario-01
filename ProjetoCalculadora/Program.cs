using ProjetoCalculadora;

Console.Write("Insira o primeiro número: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Insira o segundo número: ");
int n2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nResultado final: {Calculadora.Somar(n1, n2)}");
