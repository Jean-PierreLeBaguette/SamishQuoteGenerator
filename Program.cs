//Made by Jean-Pierre LeBaguette
//Licensed under the CC BY-NC-ND 2.0
using System;
using System.Threading;
using System.Collections.Generic;

namespace WaitIsSamLove
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] samWords = new string[]
            {
                "kerbal",
                "xDDDDD",
                "porn or trololo",
                "9999.9999999",
                "SamBelanger",
                "AtmosphereExtra vs. OptionalAtmosphere",
                "SamBelanger Serrious",
                "spam",
                "porn",
                ";)",
                "DoubleDouble",
                "OptionalAtmosphere",
                "Gameslinx author rights violation",
                "Gameslinx war",
                "super modder me",

                "x)",
                "lmao",
                "bonjour",
                "??????",
                "start the counter to zero",
                "<3",
                "(shrug girl emoji)",
                "hentai",
                "DD",
                "Kerbal vs OA & DD & SamBelangerSuperModder",
                "the fuck"
            };

            while (true)
            {
                List<int> motsChoisis = new List<int>();

                Console.WriteLine("How many Sam-ish sentences do you want to generate? (<" + samWords.Length + ")");
                string nombre = Console.ReadLine();
                int nombreInt;
                bool conversionNombre = Int32.TryParse(nombre, out nombreInt);

                bool firstTime = true;
                bool running = true;
                if (conversionNombre && running)
                {
                    Console.WriteLine("\nSentence(s) generated:");
                    for (int i = 0; i <= nombreInt-1; i++)
                    {

                        Random rnd = new Random();
                        int motChoisiNum = rnd.Next(0, samWords.Length);

                        int isWordAlreadyTook;
                        isWordAlreadyTook = motsChoisis.Find(mot => mot == motChoisiNum);

                        if ((isWordAlreadyTook != motChoisiNum) || firstTime == true)
                        {
                            motsChoisis.Add(motChoisiNum);

                            Console.WriteLine("\nWait is " + samWords[motChoisiNum] + " love" + questionMarks(questionMarks()) + " " + eggsDee());
                        }
                        else
                        {
                            i--;
                        }

                        firstTime = false;
                        if (motsChoisis.Count == samWords.Length - 1)
                        {
                            Console.WriteLine("\n\nAll the available words are used up!\nPress any key to continue..");
                            Console.ReadKey();
                            firstTime = true;
                            running = false;
                            break;
                        }
                    }
                    Console.WriteLine("\n\nAll the words has been generated");
                    End();
                }
                else
                {
                    Console.WriteLine("\nThis isn't a number!");
                    End();
                }
            }
            void End()
            {
                Console.WriteLine("Press any key to restart");
                Console.ReadKey();
                Console.Clear();
            }

            string questionMarks(string sentenceEnding = "")
            {
                Random rnd = new Random();
                int nbMarks = rnd.Next(0,11);
                for (int i = 0; i <= nbMarks; i++)
                {
                    rnd = new Random();
                    int questionOrExclamative = rnd.Next(0, 2);

                    if (questionOrExclamative == 0)
                        sentenceEnding = sentenceEnding + "?";
                    else
                        sentenceEnding = sentenceEnding + "!";
                    Thread.Sleep(10);
                }

                return sentenceEnding;
            }

            string eggsDee(string xD = "")
            {
                xD = "";
                Random rnd = new Random();
                int isEggsDeeIn = rnd.Next(0,2);

                if (isEggsDeeIn == 1)
                {
                    xD = xD + "x";

                    rnd = new Random();
                    int nbD = rnd.Next(0, 7);

                    for (int i = 0; i <= nbD; i++)
                    {
                        xD = xD + "D";
                    }
                }
                return xD;
            }
        }
    }
}
