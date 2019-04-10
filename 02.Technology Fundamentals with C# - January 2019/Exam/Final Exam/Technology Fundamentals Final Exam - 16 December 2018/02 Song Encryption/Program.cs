using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace _02_Song_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string regexArtist = @"^(?<artist>^[A-Z][a-z ]+[\s]*[\']*[a-z ]*[\s]*)";
            string regexSong = @"\:(?<song>[A-Z ]+[\s]*)";


            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                var artistAndSong = string.Empty;

                if (Regex.IsMatch(input, regexArtist) && Regex.IsMatch(input, regexSong))
                {
                    var patterAtrist = Regex.Matches(input, regexArtist);
                    var patterSong = Regex.Matches(input, regexSong);
                    string validArtist = string.Empty;
                    string validSong = string.Empty;

                    foreach (Match match in patterAtrist)
                    {
                        validArtist = match.Groups["artist"].ToString();
                    }

                    foreach (Match match in patterSong)
                    {
                        validSong = match.Groups["song"].ToString();
                    }

                    artistAndSong += ($"{validArtist}:{validSong}");

                    int length = validArtist.Length;

                    var codeOfMusic = new StringBuilder();

                    foreach (var code in artistAndSong)
                    {
                        int number = 0;
                        number = code + length;
                        if (code == ':')
                        {
                            codeOfMusic.Append("@");
                            continue;
                        }
                        else if (code == ' ')
                        {
                            codeOfMusic.Append(" ");
                            continue;
                        }
                        else if (!char.IsLetter(code))
                        {
                            codeOfMusic.Append(code);
                            continue;
                        }
                        if (code <= 90 && number > 90)
                        {
                            number -= 90;
                            number += 64;
                        }
                        if (code >= 97 && number > 122)
                        {
                            number -= 122;
                            number += 96;
                        }
                        char symbol = (char)number;

                        codeOfMusic.Append(symbol);
                    }

                    Console.WriteLine($"Successful encryption: {codeOfMusic}");

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

            }
        }
    }
}
