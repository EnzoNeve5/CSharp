string nome;
int num1, num2;
Console.Write("Qual é o seu nome: ");
nome = Console.ReadLine()!;
Console.WriteLine("Olá, " + nome);

Console.Write("Digite um número: ");
num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine(num1);

Console.Write("Digite outro número: ");
num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine(num2);

Console.WriteLine();

Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
Console.WriteLine(num1 + " x " + num2 + " = " + (num1 * num2));

Console.ReadLine();