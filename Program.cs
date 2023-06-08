//Feito por aligg <3
using System.IO;

namespace EditorDeTextoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
        Home:
            Console.Clear();
            Console.Title = "Editor de texto avançado - L.A Editor";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(" _                        _ _ _             \r\n | |                      | (_) |            \r\n | |       __ _    ___  __| |_| |_ ___  _ __ \r\n | |      / _` |  / _ \\/ _` | | __/ _ \\| '__|\r\n | |____ | (_| | |  __/ (_| | | || (_) | |   \r\n |______(_)__,_|  \\___|\\__,_|_|\\__\\___/|_|   \r\n                                            ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Bem-vindo, o que vamos fazer hoje?");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Criar novo arquivo");
            Console.WriteLine("2. Ler arquivo");


            double input = Double.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.Clear();
                Console.WriteLine("Nome do arquivo:");
                string nomeArquivo = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Digite qual a extensão do arquivo. (Sem o ponto)");
                string extension = Console.ReadLine();

                Console.Clear();
                Console.WriteLine($"{nomeArquivo}:");
                Console.WriteLine("Lines:");
                Console.WriteLine();
                Console.WriteLine();
                string conteudo = Console.ReadLine();
                CriarNovoArquivo(nomeArquivo + "." + extension, conteudo);
                Console.Clear();
                Console.WriteLine("Seu arquivo foi guardado com sucesso. Verifique a pasta do programa.");
            }
            else if (input == 2)
            {
                Console.Clear();
                Console.WriteLine("Digite o nome do arquivo que deseja abrir:");
                string nomeArquivo = Console.ReadLine();

                string conteudo = AbrirArquivo(nomeArquivo);

                if (conteudo != null)
                {
                    Console.WriteLine($"{nomeArquivo}:");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(conteudo);
                }
                else
                {
                    Console.WriteLine("Arquivo não encontrado!");
                }
            }
            else
            {
                Console.WriteLine("Comando inválido!");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para voltar a tela inicial.");
            Console.ReadKey();
            goto Home;
        }

        static void CriarNovoArquivo(string nomeArquivo, string conteudo)
        {
            File.WriteAllText(nomeArquivo, conteudo);
        }

        static string AbrirArquivo(string nomeArquivo)
        {
            if (File.Exists(nomeArquivo))
            {
                return File.ReadAllText(nomeArquivo);
            }
            else
            {
                return null;
            }
        }
    }
}