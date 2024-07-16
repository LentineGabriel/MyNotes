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
            // criando uma nova nota (1/2)
            Console.Clear();
            Console.Write("Digite o título da nota: "); string titulo = Console.ReadLine();
            Console.WriteLine("=========================");
            Console.WriteLine("Abaixo, digite o conteúdo da nota"); string conteudo = Console.ReadLine();

            // class Notas
            Notas nota = new Notas(titulo, conteudo);
            notes.Add(nota);

            // criando uma nova nota (2/2)
            Console.WriteLine("Nota adicionada com sucesso.");
            Console.WriteLine("");
            Console.WriteLine("Deseja visualizar a nota? (S/N)"); char res = char.Parse(Console.ReadLine());

            if (res == 'S') VisualizarNota();
            else System.Environment.Exit(0);
        }
        static void VisualizarNota()
        {
         Console.Clear();

         // p/ procurar a nota em todas as notas presentes
         foreach(Notas nota in notes)
            {
                Console.WriteLine($"Título da nota: {nota.Titulo}");
                Console.WriteLine($"Conteúdo da nota: {nota.Conteudo}");
                Console.WriteLine("=======");
                Console.WriteLine("");
                
                Console.WriteLine("Deseja editar nota? (S/N)"); char res = char.Parse(Console.ReadLine());
                if(res == 'S') EditarNota();
                else System.Environment.Exit(0);
            }
        }
        static void EditarNota()
        {
            Console.Clear();
            Console.Write("Digite o título da nota que deseja editar: "); string titulo = Console.ReadLine();

            Notas nota = notes.Find(n => n.Titulo == titulo);

            if(nota != null)
            {
                Console.Write("Digite o novo título para a nota: "); string novoTitulo = Console.ReadLine();
                nota.Titulo = novoTitulo;
                Console.WriteLine("Digite o novo conteúdo da nota abaixo"); string novoConteudo = Console.ReadLine();
                nota.Conteudo = novoConteudo;

                Console.WriteLine("Nota editada com sucesso.");
            }
            else Console.WriteLine("Nota não encontrada");
            Console.WriteLine("");
            Console.WriteLine("Pré-Visualização");
            Console.WriteLine($"Novo título: {nota.Titulo}");
            Console.WriteLine($"Novo conteúdo: {nota.Conteudo}");
        }
        static void ExcluirNota()
        {
            Console.Clear();
            Console.Write("Digite o título da nota que deseja excluir: "); string titulo = Console.ReadLine();

            Notas nota = notes.Find(n => n.Titulo == titulo);

            if (nota != null)
            {
                notes.Remove(nota);
                Console.WriteLine("Nota excluída com sucesso.");
            }
            else Console.WriteLine("Nota não encontrada");
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