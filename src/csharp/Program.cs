using System;
using System.Globalization; // Importante para aceitar pontos em números decimais

namespace SegundoRepositorio.Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear(); // Limpa a tela para ficar bonito
            Console.WriteLine("=== 🎓 Sistema de Cálculo de Médias 🎓 ===");

            // 1. Entrada de Dados
            Console.Write("Digite o nome do aluno: ");
            // O '?? ""' significa: se o resultado for nulo, use aspas vazias.
            string nomeAluno = Console.ReadLine() ?? "";

            Console.Write("Digite a primeira nota (0-10): ");
            // double.Parse converte o texto digitado para número decimal
            // Se vier nulo, usamos "0" para evitar que o programa quebre na conversão
            double nota1 = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

            Console.Write("Digite a segunda nota (0-10): ");
            // Se vier nulo, usamos "0" para evitar que o programa quebre na conversão
            double nota2 = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);

            // 2. Processamento (Cálculo da Média)
            double media = (nota1 + nota2) / 2;

            // 3. Lógica de Decisão (Regra de Negócio)
            string status;
            
            if (media >= 7)
            {
                status = "APROVADO 🟢";
            }
            else if (media >= 5)
            {
                status = "EM RECUPERAÇÃO 🟡";
            }
            else
            {
                status = "REPROVADO 🔴";
            }

            // 4. Saída de Resultados (Output)
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Aluno: {nomeAluno}");
            Console.WriteLine($"Média Final: {media.ToString("F1", CultureInfo.InvariantCulture)}"); // F1 limita a 1 casa decimal
            Console.WriteLine($"Situação: {status}");
            Console.WriteLine("---------------------------------");
        }
    }
}
