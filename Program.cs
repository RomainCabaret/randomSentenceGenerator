using System;

namespace randomSentenceGenerator
{
    class Program
    {
        static string GetRandomElement(string[] table)
        {
            var rnd = new Random();
            
            int result = rnd.Next(table.Length);

            return table[result];
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var subjets = new string[] {
                "Un lapin",
                "Une grand-mère",
                "Un chat",
                "Un bonhomme de neige",
                "Une limace",
                "Une fee",
                "Un magicien",
                "Une tortue",
            };

            var verbs = new string[]
            {
                "mange",
                "écrase",
                "détruit",
                "observe",
                "attrape",
                "regarde",
                "avale",
                "néttoie",
                "se bat avec",
                "s'accroche à",
            };

            var complements = new string[]
            {
                "un arbre",
                "un livre",
                "la lune",
                "le soleil",
                "un serpent",
                "une carte",
                "une girafe",
                "le ciel",
                "une piscine",
                "un gateau",
                "une souris",
                "un crapaud",
            };

            const int NB_SENTENCE = 100;

            int nbDuplicateSentence = 0;

            List<string> sentences = new List<string>();

            while (sentences.Count < NB_SENTENCE)
            {

                string selectedSubject = GetRandomElement(subjets);
                string selectedVerbs = GetRandomElement(verbs);
                string selectedComplements = GetRandomElement(complements);

                string sentence = $"{selectedSubject} {selectedVerbs} {selectedComplements}";
                sentence = sentence.Replace("à le", "au");

                if (!sentences.Contains(sentence))
                {
                    sentences.Add(sentence);
                    Console.WriteLine(sentence);
                }
                else
                {
                    nbDuplicateSentence++;
                }
            }

            for (int i = 1; i < NB_SENTENCE+1; i++)
            {

            }

            Console.WriteLine($"\n Nombre de phrases uniques : {sentences.Count}");
            Console.WriteLine($"\n Nombre de doublons évités : {nbDuplicateSentence}");

        }
    }
}