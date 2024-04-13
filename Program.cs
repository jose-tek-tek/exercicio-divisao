double numerador, denominador, resultado;

Console.Write("Digite o deenominador.....:");
numerador = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o denominador...: ");
denominador = Convert.ToDouble(Console.ReadLine());

if (denominador != 0)
{
    resultado = numerador / denominador;
    Console.WriteLine($"{numerador} dividido por {denominador} é {resultado}");
}
else
{
    Console.WriteLine("não é possivel dividie por zero.");
}