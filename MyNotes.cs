using System;

namespace MyNotes
{
    class MyNotes
    {
        static List<Notas> notes = new List<Notas>();
        static void Main(string[] args)
        {
            // Menu
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Adicionar nota");
            Console.WriteLine("2 - Visualizar nota");
            Console.WriteLine("3 - Editar nota");
            Console.WriteLine("4 - Excluir nota");
            Console.WriteLine("5 - Sair");
            var option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1: AdicionarNota(); break;
                case 2: VisualizarNota(); break;
                case 3: EditarNota(); break;
                case 4: ExcluirNota(); break;
                case 5: System.Environment.Exit(0); break;
                default: Console.WriteLine("Opção inválida"); break;
            }
        }
        static void AdicionarNota()
        {
            Console.Clear();
            Console.Write("Digite o título da nota: "); string titulo = Console.ReadLine();
            Console.WriteLine("=========================");
            Console.WriteLine("Abaixo, digite o conteúdo da nota"); string conteudo = Console.ReadLine();

            Notas nota = new Notas(titulo, conteudo);
            notes.Add(nota);
            Console.WriteLine("Nota adicionada com sucesso.");
            Console.WriteLine("");
            Console.WriteLine("Deseja visualizar a nota? (S/N)"); char res = char.Parse(Console.ReadLine());

            if (res == 'S') VisualizarNota();
            else System.Environment.Exit(0);
        }
        static void VisualizarNota()
        {
         Console.Clear();
         foreach(Notas nota in notes)
            {
                Console.WriteLine($"Título da nota: {nota.Titulo}");
                Console.WriteLine($"Conteúdo da nota: {nota.Conteudo}");
                Console.WriteLine("=======");
                Console.WriteLine("");
                
                Console.WriteLine("Deseja criar uma nova nota?"); char res = char.Parse(Console.ReadLine());
                if(res == 'S') AdicionarNota();
                else System.Environment.Exit(0);
            }
        }
        static void EditarNota()
        {
            
        }
        static void ExcluirNota()
        {

        }
    }
    class Notas
    {
        public string Titulo { get; set; }
        public string Conteudo { get; set; }

        public Notas(string titulo, string conteudo)
        {
            Titulo = titulo;
            Conteudo = conteudo;
        }
    }
}