using _08_ExResolvidoConjuntos.Entities;
using System.IO;

namespace _08_ExResolvidoConjuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            DESCRICAO:

            Um site de internet registra um log de acessos dos usuários. Um registro de log consiste no nome de usuário
            e o instante em que ousuário acessou o site no padrão ISO 8601, separados por espaço,conforme exemplo. Fazer
            um programa que leia o log de acessos apartir de um arquivo, e daí informe quantos usuários distintos acessaram 
            o site.   
            */

            Console.Write("Enter file full path: "); // O arquivo se enontra na mesma pasta do projeto
            string path = Console.ReadLine();

            HashSet<User> users = new HashSet<User>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] data = line.Split(' ');
                        string userName = data[0];
                        DateTime acessTime = DateTime.Parse(data[1]);

                        users.Add(new User(userName, acessTime));
                    }
                }

                Console.Write("Total users: " + users.Count);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
