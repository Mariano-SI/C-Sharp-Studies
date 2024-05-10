namespace _09_ExPropostoDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Descrição

            /*
                Na contagem de votos de uma eleição, são gerados vários registrosde votação contendo 
                o nome do candidato e a quantidade de votos(formato .csv) que ele obteve em uma urna 
                de votação. Você devefazer um programa para ler os registros de votação a partir de um 
                arquivo, e daí gerar um relatório consolidado com os totais de cadacandidato. 
            */

            Console.Write("Enter file full path: "); // O arquivo se enontra na mesma pasta do projeto
            string path = Console.ReadLine();

            Dictionary<string, int> votes = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string candidateName = line[0];
                        int cityVotes = int.Parse(line[1]);
                        if (!votes.ContainsKey(candidateName))
                        {
                            votes[candidateName] = cityVotes;
                        }
                        else
                        {
                            votes[candidateName] += cityVotes;
                        }

                    }
                }

                foreach (KeyValuePair<string, int> candidateVote in votes)
                {
                    Console.WriteLine(candidateVote.Key + ": "+ candidateVote.Value);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
