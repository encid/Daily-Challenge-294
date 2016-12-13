using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args)
        {

            Console.WriteLine("ladilmy, daily ... " + Scrabble("ladilmy", "daily"));
            Console.WriteLine("eerriin, eerie ... " + Scrabble("eerriin", "eerie"));
            Console.WriteLine("orrpgma, program ... " + Scrabble("orrpgma", "program"));
            Console.WriteLine("orppgma, program ... " + Scrabble("orppgma", "program"));

            Console.ReadLine();
        }

        static bool Scrabble(string tiles, string word)
        {
            string temp = "";

            for (int i = 0; i < word.Length; i++) {
                if (tiles.Contains(word[i])) {
                    temp += word[i];
                    tiles = TrimTiles(tiles, word[i]);
                }
            }

            if (temp == word) {
                return true;
            }
            return false;
        }

        static string TrimTiles(string tiles, char letter)
        {
            string temp = "";

            for (int i = 0; i < tiles.Length; i++) {
                if (tiles.IndexOf(letter) != -1) {
                    temp = tiles.Remove(tiles.IndexOf(letter), 1);
                    break;
                }                
            }

            if (temp != tiles) {
                return temp;
            }
            return tiles;
        }
    }
}
