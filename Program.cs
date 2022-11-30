using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadAndWriteFilesChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] map = File.ReadAllLines(@"Mapfile.txt");
                        
            for (int y = 0; y < map.GetLength(0); y++)
            {
                Console.WriteLine(map[y]);
            }

            Console.ReadKey();

            File.WriteAllLines("Savefile.txt", map);

            Console.ReadKey();
        }
    }    
}
