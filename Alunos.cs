using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    internal class Alunos
    {
        /* 
            * Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina.
            * Cada objeto dessa classe deve guardar os seguintes dados do aluno:
            * matrícula, nome, 2 notas de prova e 1 nota de trabalho.
            * Construa os seguintes métodos para esta classe:
            * métodos construtores,
            * registrar nota de cada prova e trabalho,
            * calcula a média final do aluno (cada prova tem peso 2,5 e o trabalho tem peso 2).
            * Teste na main, se atente para o que precisar ser public, private, parametros, retornos.. 
        */

        private int matricula;
        private string nome;
        private double notaProva1;
        private double notaProva2;
        private double notaTrabalho;
        private double pesoProva = 2.5;
        private double pesoTrabalho = 2.0;

        public Alunos(int matricula, string nome)
        {
            this.nome = nome;
            this.matricula = matricula;
        }

        public void registrarNotas(double notaProva1)
        {
            this.notaProva1 = notaProva1;
        }

        public void registrarNotas(double notaProva1, double notaProva2)
        {
            this.notaProva1 = notaProva1;
            this.notaProva2 = notaProva2;
        }
        
        public void registrarNotas(double notaProva1, double notaProva2, double notaTrabalho)
        {
            this.notaProva1 = notaProva1;
            this.notaProva2 = notaProva2;
            this.notaTrabalho = notaTrabalho;
        }

        public double calcularMedia()
        {
            notaProva1 *= pesoProva;
            notaProva2 *= pesoProva;
            notaTrabalho *= pesoTrabalho;

            double somaDosPesos = pesoTrabalho + (pesoProva * 2);

            double media = (notaProva1 + notaProva2 + notaTrabalho) / somaDosPesos;
            return Math.Round(media, 2);
        }

    }
}
