using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using _2910_Lab_1;
using System.Xml.Linq;

namespace _2910_Lab_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string folder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
            string filepath = folder + Path.DirectorySeparatorChar + "videogames.csv";

            List<VideoGame> games = new List<VideoGame>();

            using(var sr = new StreamReader(filepath))
            {
                while (!sr.EndOfStream) 
                {

                    string? line = sr.ReadLine();

                   
                    string[] lineElements = line.Split(',');

                    VideoGame v = new VideoGame()
                    {
                        Name = lineElements[0].Trim(),
                        Platform = lineElements[1].Trim(),
                        Year = lineElements[2],
                        Genre = lineElements[3].Trim(),
                        Publisher = lineElements[4].Trim(),
                        NA_Sales = lineElements[5].Trim(),
                        EU_Sales = lineElements[6].Trim(),
                        JP_Sales = lineElements[7].Trim(),
                        Other_Sales = lineElements[8].Trim(),
                        Global_Sales = lineElements[9].Trim()
                    };
                    games.Add(v);
                }
                
            }

            games.Sort();

            foreach (var v in games)
            {
                Console.WriteLine(v);
                Console.WriteLine("-------------------------------\n");
            }
           
            
            var specPub = games.Where(v => v.Publisher == "Ubisoft");
            Console.WriteLine("\n\n\n\n\n\nAll games from Ubisoft");
            foreach (var v in specPub)
            {
                Console.WriteLine(v);
                Console.WriteLine("--------------------------------\n");
            }
            
            double numpub = specPub.Count();
            double p = numpub / games.Count() * 100;

            Console.WriteLine($"Out of {games.Count} games, there are {numpub} Ubisoft Games. Which is {p:0.##}%\n");

            var specGenre = games.Where(v => v.Genre == "Role-Playing");
            Console.WriteLine("\n\n\n\n\n\nAll Role-Playing Games");
            foreach (var v in specGenre)
            {
                Console.WriteLine(v);
                Console.WriteLine("--------------------------------\n");
            }
            
            double numGen = specGenre.Count();
            double Gp = numGen / games.Count() * 100;

            Console.WriteLine($"Out of {games.Count} games, there are {numGen} Ubisoft Games. Which is {Gp:0.##}%\n");

            Console.Write("Enter the Genre of Game you'd like to search for: ");
            Console.WriteLine("(Action, Adventure, Fighting, Misc, Racing, Role-Playing, Shooter, Simulation, Strategy, Sports)");
            string Genretype = Console.ReadLine().Trim();

            Console.WriteLine($"Now searching for {Genretype} games...\n");

            GenreData(games, Genretype);
            
            Console.Write("Enter the Game Publisher you'd like to search for: ");
            Console.WriteLine("Ubisoft, Sega, Level 5");
            string Pubtype = Console.ReadLine().Trim();

            Console.WriteLine($"Now searching for {Pubtype}'s games...\n");

            PubData(games, Pubtype);

            static void GenreData(List<VideoGame> games, string type)
            {
                float numGames = games.Count;

                var specTypes = new List<VideoGame>();

                foreach (var v in games)
                {
                    if (v.Genre == type) specTypes.Add(v);
                }

                float numType = specTypes.Count;

                var pct = numType / numGames * 100;
                Console.WriteLine(pct);

                Console.WriteLine($"There are {numType} {type} games out of {numGames} which is {pct:0.##}%");
            }

            static void PubData(List<VideoGame> games, string type)
            {
                float numGames = games.Count;

                var specTypes = new List<VideoGame>();

                
                foreach (var v in games)
                {
                    if (v.Publisher == type) specTypes.Add(v);
                }

                float numType = specTypes.Count;

                var pct = numType / numGames * 100;
                Console.WriteLine(pct);

                Console.WriteLine($"There are {numType} {type} games out of {numGames} which is {pct:0.##}%");
            }
        }
    }

}



