using Revisao_aula1;

class Program
{
    static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();

        biblioteca.AdicionarLivro("LIVRO1", "AUTOR 1");
        biblioteca.AdicionarLivro("LIVRO2", "AUTOR 2");

        biblioteca.AdicionarLeitor("Alice", "Silva");
        biblioteca.AdicionarLeitor("Bob", "Santos");

        biblioteca.EmprestarLivro(0, 1);
        biblioteca.EmprestarLivro(1, 0);

        biblioteca.ListarLivrosDisponiveis();
        biblioteca.ListarLivrosEmprestados();
    }
}