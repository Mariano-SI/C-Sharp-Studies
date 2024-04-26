using System.IO;

namespace Cap013_TrabalhandoComArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //No diretoório C criei uma pasta chamada PastaTeste e um arquivo de texto nela chamado File1.txt
    
            string sourcePath = @"c:\PastaTeste\File1.txt"; //o @ serve para não ter que usar barra invertida dupla, sem ele o path seria c:\\PastaTeste\\File1.txt
            string targetPath = @"c:\PastaTeste\File2.txt"; //esse File2 não foi criado, apenas o File1

            string[] lines = File.ReadAllLines(sourcePath);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath); //intanciei um objeto que esta associado ao arquivo que passei

                fileInfo.CopyTo(targetPath); //Como esse arquivo não existia antes agora ele foi criado, se eu rodar dnovo dará erro pq o arquivo existe agora
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
