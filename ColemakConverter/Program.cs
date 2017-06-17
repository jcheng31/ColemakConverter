using System;
using System.IO;
using System.Linq;

namespace ColemakConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputPath = args[0];

            string[] inputLines = File.ReadAllLines(inputPath);

            var converted = inputLines.Select(line => QWERTYDecrypter.QWERTYStringToColemak(line));

            var outputPath = args[1];

            File.WriteAllLines(outputPath, converted);
        }
    }
}