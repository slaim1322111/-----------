using System;
using System.IO;
using System.Text;
using System.Linq;

class Program
{
    static void Main()
    {
        string inputFilePath = @"D:\12-2015\1.txt.txt"; 
        string outputFilePath = @"D:\12-2015\2.txt"; 

        try
        {
           
            string[] sentences = File.ReadAllLines(inputFilePath, Encoding.UTF8);

           
            string[] sortedSentences = sentences.Select(sentence =>
            {
                string[] words = sentence.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length)); 
                return string.Join(" ", words);
            }).ToArray();

           
            File.WriteAllLines(outputFilePath, sortedSentences, Encoding.UTF8);

            Console.WriteLine("Программа успешно завершила работу.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Не удалось найти входной файл.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
