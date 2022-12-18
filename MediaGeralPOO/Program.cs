using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //desafio de media de alunos com conceito de P.O.O

            Console.Title = "#### MEDIA GERAL DE ALUNOS #####";
            Console.WriteLine("Quantos alunos ? ");
            int nAlunos = int.Parse(Console.ReadLine());

            Console.WriteLine();

            //vetor com uma quantidade dinamica
            Aluno[] alunos = new Aluno[nAlunos];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.Clear();
                Console.Write("Aluno #" + (i + 1) + " Nome.. : ");
                string nome = Console.ReadLine();

                Console.Write("Aluno #" + (i + 1) + " Provas: ");
                int provas = int.Parse(Console.ReadLine());


                alunos[i] = new Aluno(nome, provas);
                Console.WriteLine("Insira as notas do aluno " + nome);
                alunos[i].InserirNotas();

            }
            Console.Clear() ;

            double mediageral = 0;

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine("Aluno: " + aluno.Nome);
                Console.WriteLine("Aluno: " + aluno.media);

                //quebra de linha
                Console.WriteLine();
                mediageral += aluno.media;
            }

            double resultadoFinal = mediageral / alunos.Length;
            Console.WriteLine("Media geral dos alunos : " + resultadoFinal);

            Console.ReadKey();
        }
    }
}
