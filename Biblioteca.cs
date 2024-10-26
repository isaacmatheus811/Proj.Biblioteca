using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Biblioteca
    {
        List<Livro> livros;
        List<Usuario> usuarios;
        List<Emprestimo> emprestimos;

        public Biblioteca()
        {
            this.livros = new List<Livro>();
            this.usuarios = new List<Usuario>();
            this.emprestimos = new List<Emprestimo>();
        }
        public void carregarDados()
        {

        }
        public void salvarDados()
        {

        }
        private Usuario selecionarUsuario()
        {
            if (usuarios.Count == 0)
            {
                Console.WriteLine("Não á usuario Cadastrado!");
                return null;

            }
            Usuario usuario = usuarios[0];
            return usuario;
        }
        private Livro seleiconarLivro()
        {
            if (livros.Count == 0)
            {
                Console.WriteLine("Não á livros Cadastrados!");
                return null;
            }
            Livro livro = livros[0];
            return livro;
        }

        private Emprestimo selecionarEmprestimo()
        {
            if (emprestimos.Count == 0)
            {
                Console.WriteLine("Não á emprestimos cadastrados!");
                return null;

            }
            Emprestimo emprestimo = emprestimos[0];

            return emprestimo;
        }
        public void cadastrarLivro()
        {
            Livro novolivro = new Livro();

            livros.Add(novolivro);
        }
        public void marcarlivroComoPerdido()
        {
            Livro livro = seleiconarLivro();
            if (livro == null) return;
            livro.perdido = true;
            salvarDados();
        }
        public void autalizarDadosDoLivro()
        {
            Livro livro = seleiconarLivro();
            if (livro == null) return;

            salvarDados();

        }
        public void cadastrarNovoUsuario()
        {
            Usuario novoUsuario = new Usuario();

            usuarios.Add(novoUsuario);
            salvarDados();
        }
        public void atualizarCadastroUsuario()
        {
            Usuario usuario = selecionarUsuario();
            if (usuario == null) return;

            salvarDados();
        }
        public void banirUsuario()
        {
            Usuario usuario = selecionarUsuario();
            if (usuario == null) return;
            usuario.banido = true;
            salvarDados();

        }
        public void emprestarLivro()
        {
            Livro livro = seleiconarLivro();
            if (livro == null) return;

            Usuario usuario = selecionarUsuario();
            if (livro == null) return;

            Emprestimo emprestimo = new Emprestimo();
            emprestimo.Id_livro = livro.Id;
            emprestimo.Id_usuario = usuario.id;
            livro.disponivel = false;
            emprestimo.dataDevolucao = emprestimo.dataEmprestimo();

            emprestimo.Add(emprestimo);
            salvarDados();
        }
        public void devolverLivro()
        {
            Emprestimo emprestimo = selecionarEmprestimo();
            if (emprestimo == null) return;

            foreach (Livro livro in livros)
            {
                if (livro.id == emprestimo.Id_livro)
                {
                    livro.disponivel = true;
                }
            }

        }   emprestimo.dataDevolucao = DataTime.Now;
            emprestimo.devolvido = true;


            
























    }   

}
