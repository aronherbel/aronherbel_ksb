using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballmanschaft
{
    internal class Manschaft
    {


        public string clubName { get; private set; }

        public List<Feldspieler> feldspielerListe { get; set; }
        private Torwart torwart { get; set; }  

        public int  geschosseneTore { get; set; }
       

        public bool ballBesitz { get; set; } = true;

        public string currentTeam { get; set; } = "Barcelona";
        private bool geklappt { get; set; } = true; 
         
        public Manschaft(string name, Torwart torwart) {
            
            this.clubName = name;
            this.feldspielerListe = new List<Feldspieler>();
            this.torwart = torwart;
        
        }

        public void AddTorwart(Torwart newTorwart)
        {
            if (torwart == null)
            {
                torwart = newTorwart;
            }
            else
            {
                Console.WriteLine("Die Manschaft hat bereits ein Torwart");
            }
        }


        public void AddFeldspieler(Feldspieler feldspieler)
        {
            if(feldspielerListe.Count < 10)
            {
                feldspielerListe.Add(feldspieler);
            }
            else
            {
                Console.WriteLine("Die Manschaft hat bereits 10 Feldspieler");
            }
        }

        public int Spielzug()
        {  

            while (ballBesitz == true)
            {
                Random random = new Random();

                int index = random.Next(feldspielerListe.Count) + 1;


                Feldspieler currentPlayer = feldspielerListe[index];

                torwart.Abstoss(torwart.NameTorwart);
                while (geklappt != false)
                {
                    currentPlayer.Graetschen(currentPlayer.Name, clubName);
                    geklappt = (random.Next(2) == 0);
                    if (geklappt == false)
                    {
                        ballBesitz = false;
                       
                    }
                    currentPlayer.Dribbeln(currentPlayer.Name, clubName);
                    geklappt = (random.Next(2) == 0);

                    if (geklappt == false)
                    {
                        ballBesitz = false;
                       
                    }

                    currentPlayer.AufsTorSchiessen(currentPlayer.Name, clubName);
                    geklappt = (random.Next(2) == 0);

                    if (geklappt == true)
                    {
                        Console.WriteLine($"Tooooor für {clubName}");
                        geschosseneTore++;
                        ballBesitz = false;
                        
                    }
                }
            }
            

           
            return geschosseneTore;
        }

    }
}


