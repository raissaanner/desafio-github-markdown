internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("=Programa da media=");

        Console.WriteLine("Informe seu nome");
        string nome = Console.ReadLine();

        Console.WriteLine("Informe sua primeira nota:");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe sua segunda nota:");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe sua terceira nota:");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        //2º processamento:
        double media = (nota1 + nota2 + nota3) / 3;

        string situacao;
        if (media >= 6)
        {
            situacao = "Aprovado";
        }
        else
        {
            situacao = "DP";
        }
        //3° saída de dados:
        Console.WriteLine("\n-- Resultado --");
        Console.WriteLine($"Aluno:{nome}");
        Console.WriteLine($"Média:{media}");
        Console.WriteLine($"Situacao: {situacao}");
    }
}