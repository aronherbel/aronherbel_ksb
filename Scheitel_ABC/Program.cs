namespace Scheitel_ABC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int auswahl;

            Console.WriteLine("Scheitelpunkt berechnen\nWählen Sie ihre Methode\n[1]ABC-Formel\t[2]PQ-Formel");
            Console.Write("Auswahl: ");
            string Auswahl = Console.ReadLine();

            auswahl = int.Parse(Auswahl);

            switch(auswahl)
            {
                case 1:
                    string A;
                    string B;
                    string C;

                    Console.WriteLine("Gebe deine Werte für A, B und C ein um den Scheitel zu berechnen");
                    Console.Write("A:");
                    A = Console.ReadLine();
                    Console.Write("B:");
                    B = Console.ReadLine();
                    Console.Write("C:");
                    C = Console.ReadLine();



                    int a = int.Parse(A);
                    int b = int.Parse(B);
                    int c = int.Parse(C);


                    string abc = Formels.Abc_Formel(a, b, c);


                    Console.WriteLine("deine koordinaten sind: " + abc);

                break;

                case 2:
                    
                    string P;
                    string Q;


                break;


            }
            
           
            



        }
    }
}