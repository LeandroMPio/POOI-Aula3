using Aula3;

namespace Program
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Informe o nome do Aluno");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe a matricula do Aluno");
            int matricula = int.Parse(Console.ReadLine());

            Alunos alunos = new(matricula, nome);

            Console.WriteLine("Informe a nota da Prova1");
            double notaProva1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a nota da Prova2");
            double notaProva2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a nota do Trabalho");
            double notaTrabalho = double.Parse(Console.ReadLine());

            alunos.registrarNotas(notaProva1, notaProva2, notaTrabalho);

            Console.WriteLine(alunos.calcularMedia());
        }
    }

}
