namespace ExercicioOO11_DictionaryCandidate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr =  File.OpenText(path))
                {
                    Dictionary<string, int> set = new Dictionary<string, int>();
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string candidateName = line[0];
                        int candidateVote = int.Parse(line[1]);
                        
                        if(set.ContainsKey(candidateName))
                        {
                            set[candidateName] += candidateVote;
                        }
                        else
                        {
                            set[candidateName] = candidateVote;
                        }
                    }
                    foreach (KeyValuePair<string, int> obj in set)
                    {
                        Console.WriteLine($"{obj.Key}: {obj.Value}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred {e.Message}");
            }
        }
    }
}