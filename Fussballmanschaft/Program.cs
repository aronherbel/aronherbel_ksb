using Fussballmanschaft;
using System;
using System.Collections.Generic;

namespace Fussballmannschaft
{
    class Program
    {
        static void Main(string[] args)
        {

            Torwart heimTormart = new Torwart("Terstegen");
            Torwart gastTorwart = new Torwart("Keylor Navas");

            Manschaft HeimManschaft = new Manschaft("Barcelona", heimTormart);
            Manschaft GastManschaft = new Manschaft("Real Madrid", gastTorwart);

            for (int a = 1; a <= 10; a++)
            {
                HeimManschaft.AddFeldspieler(new Feldspieler { Name = $"{a}" });

                GastManschaft.AddFeldspieler(new Feldspieler { Name = $"{a}" });
                
            }

            Console.WriteLine("Spieler in Barcelona:");
            foreach (Feldspieler spieler in HeimManschaft.feldspielerListe)
            {
                Console.WriteLine(spieler.Name);
            }


            Console.WriteLine("\nSpieler in Real Madrid:");
            foreach (Feldspieler spieler in GastManschaft.feldspielerListe)
            {
                Console.WriteLine(spieler.Name);
            }


            Spiel elClassico = new Spiel(HeimManschaft.clubName, GastManschaft.clubName);

   

            Resultat result = new Resultat();

            result.geschosseneToreHeimManschaft = HeimManschaft.Spielzug();
            result.geschosseneToreGastManschaft = GastManschaft.Spielzug();

            Console.WriteLine($"Scorer: {elClassico.heimManschaft} {result.geschosseneToreHeimManschaft} - {result.geschosseneToreGastManschaft} {elClassico.gastManschaft}");
        }
    }

}