using System.Text.RegularExpressions;
using ValidateProgram;

Console.WriteLine("Aplicação para Verificar se o número pertence a sequencia de Fibonacci\r\n\r\n ");
Console.Write("Entre com um número: ");
string? numberStr = Console.ReadLine();
if((Regex.IsMatch(numberStr,"[^0-9]"))||String.IsNullOrEmpty(numberStr))
    Console.WriteLine("Erro. Você não forneceu um número!");
else
    if(new Validate( int.Parse(numberStr)).ValidateNumber())
        Console.WriteLine($"O número {numberStr} pertence a sequência Fibonacci");
    else
        Console.WriteLine($"O número {numberStr} não pertence a sequência Fibonacci");

Console.WriteLine();
Console.WriteLine("Pressione Qualquer tecla para Terminar");
Console.ReadKey();
