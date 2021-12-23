using System;

namespace GuessRandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int geheim = 0;
            int guess = 0;

            Console.WriteLine("Bitte die Geheime Zahl eingeben: ");
            geheim = Convert.ToInt32(Console.Read());

            for (int anzhalVersuche = 11 ; anzhalVersuche >= 0 ; anzhalVersuche--)
            {
                Console.WriteLine("Wie groß denken Sie ist meine Zahl?");
                guess = Convert.ToInt32(Console.ReadLine());

                if (geheim == guess)
                {
                    Console.WriteLine("Richtig! Sie haben gewonnen!");
                    Console.WriteLine("Sie haben "+ anzhalVersuche+ " Versuche benötigt um meine Zahl zu erraten");
                    Console.ReadLine();
                }
                if (geheim > guess)
                {
                    Console.WriteLine("Nein. meine Zahl ist größer als die von Ihnen getippte");
                    Console.WriteLine("Sie haben noch "+anzhalVersuche+" weitere Versuche übrig!");
                }
                else
                {
                    Console.WriteLine("Nein. meine Zahl ist kleiner als die von Ihnen getippte");
                    Console.WriteLine("Sie haben noch " + anzhalVersuche + " weitere Versuche übrig!");
                }
            }
            
        }
    }
}
