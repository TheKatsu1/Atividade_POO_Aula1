using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao_aula1
{
    class Biblioteca {

        private List livros;
        private List leitores;

        public Biblioteca()
    {
        livros = new List();
        leitores = new List();
    }

    public void AdicionarLivro(string titulo, string autor)
    {
        Livro livro = new Livro(titulo, autor);
            livros.Add(livro);
    }

    public void AdicionarLeitor(string nome, string sobrenome)
    {
        Leitor leitor = new Leitor(nome, sobrenome);
        leitores.Add(leitor);
    }

    public void EmprestarLivro(int livroIndex, int leitorIndex)
        {
            if (livroIndex < 0 || livroIndex >= livros.Count ||
            leitorIndex < 0 || leitorIndex >= leitores.Count)
            {
                Console.WriteLine("Índice de livro ou leitor inválido.");
                return;
            }
            else
            {
                Livro livro = livros[livroIndex];
                Leitor leitor = leitores[leitorIndex];

                if (livro.Estado)
                {
                    livro.Estado = false;
                    Console.WriteLine($"O livro '{livro.Titulo}' foi emprestado para {leitor.Nome} {leitor.Sobrenome}.");
                }
                else
                {
                    Console.WriteLine("O livro não está disponível para empréstimo.");
                }
            }
        }
        
    public void DevolverLivro(int livroIndex, int leitorIndex)
    {
        if (livroIndex < 0 || livroIndex >= livros.Count ||
        leitorIndex < 0 || leitorIndex >= leitores.Count)
        {
            Console.WriteLine("Índice de livro ou leitor inválido.");
            return;
        }

        Livro livro = livros[livroIndex];
        Leitor leitor = leitores[leitorIndex];

        if (!livro.Estado)
        {
            livro.Estado = true;
            Console.WriteLine($"O livro '{livro.Titulo}' foi devolvido por {leitor.Nome} {leitor.Sobrenome}.");
        }
        else
        {
            Console.WriteLine("O livro já está disponível.");
        }
    }

    public void ListarLivrosDisponiveis()
    {
        Console.WriteLine("Livros disponíveis:");
        foreach (var livro in livros)
        {
            if (livro.Estado)
            {
                Console.WriteLine($"- {livro.Titulo} ({livro.Autor})");
            }
        }
    }

    public void ListarLivrosEmprestados()
    {
        Console.WriteLine("Livros emprestados:");
        foreach (var livro in livros)
        {
            if (!livro.Estado)
            {
                Leitor leitor = EncontrarLeitorPorLivro(livro);
                Console.WriteLine($"- {livro.Titulo} ({livro.Autor}) - Emprestado para: {leitor.Nome} {leitor.Sobrenome}");
            }
        }
    }

    private Leitor EncontrarLeitorPorLivro(Livro livro)
    {
        foreach (var leitor in leitores)
        {
            if (!livro.Estado)
            {
                if (leitor == leitores.Find(leitor => leitor.Equals(leitor)))
                    return leitor;
            }
        }
        return null;
    }
}

    internal class List
    {
        internal void Add(Livro livro)
        {
            throw new NotImplementedException();
        }

        internal void Add(Leitor leitor)
        {
            throw new NotImplementedException();
        }
    }
}
