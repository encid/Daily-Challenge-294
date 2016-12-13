using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args)
        {

            Console.WriteLine("ladilmy, daily ... " + Scrabbles("ladilmy", "daily"));
            Console.WriteLine("eerriin, eerie ... " + Scrabbles("eerriin", "eerie"));
            Console.WriteLine("orrpgma, program ... " + Scrabbles("orrpgma", "program"));
            Console.WriteLine("orppgma, program ... " + Scrabbles("orppgma", "program"));

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

        static bool Scrabbles(string letters, string word)
        {
            var letterList = letters.ToList();

            foreach (var character in word) {
                if (letterList.Contains(character)) {
                    letterList.Remove(character);                
                }
                else {
                    return false;
                }
            }

            return true;
        }
    }
}
