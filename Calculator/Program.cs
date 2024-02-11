using System.Transactions;

namespace Calculator
{
internal class Program
{
    static void Main(string[] args)
    {
            

            Console.WriteLine("Aron's Calculator \t Version 1.0\n--------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Enter your Operation\n[1]Addition\t[2]Subtraktion\t[3]Multiplikation\t[4]Division\t[5]Stop");

            Operations operations = new Operations();
            operations.LastResult = 0;

            string Auswahl = Console.ReadLine();
            int auswahl = int.Parse(Auswahl);

            while (true) {
                if(auswahl == 5)
                {
                    Console.WriteLine("Abruch...");
                    break; 
                }

                switch(auswahl)
                {
                
                   
                    case 1:
                        Console.WriteLine("Enter numbers:");
                        string A = Console.ReadLine();
                        string B = Console.ReadLine();
                        int a = int.Parse(A);
                        int b = int.Parse(B);
                        int result = Operations.Additon(a, b);
                        Console.WriteLine(a + "+" + b +"="+ result);
                        operations.LastResult = result;
                        break;

                    case 2:
                        Console.WriteLine("Enter numbers:");
                        string C = Console.ReadLine();
                        string D = Console.ReadLine();
                        int c = int.Parse(C);
                        int d = int.Parse(D);
                        int resultS = Operations.Subtraktion(c, d);
                        Console.WriteLine(c + "-" + d + "=" + resultS);
                        operations.LastResult = resultS;
                    break;

                    case 3:
                        Console.WriteLine("Enter numbers:");
                        string F = Console.ReadLine();
                        string G = Console.ReadLine();
                        int f = int.Parse(F);
                        int g = int.Parse(G);
                        int resultM = Operations.Multiplikation(g, f);
                        Console.WriteLine(g + "x" + f + "=" + resultM);
                        operations.LastResult = resultM;
                        break;

                    case 4:
                        Console.WriteLine("Enter numbers:");
                        string H = Console.ReadLine();
                        string I = Console.ReadLine();
                        int h = int.Parse(H);
                        int i = int.Parse(I);
                        int resultD = Operations.Division(h, i);
                        Console.WriteLine(h + ":" + i + "=" + resultD);
                        operations.LastResult = resultD;
                        break;
                    
                    default:
                        Console.WriteLine("Falsche eingabe");
                        break;
                }
                
                Console.WriteLine("Wollen sie mit dem Ergebnis fortfahren?[Ja,1][nein,2]\n");

                string auswahlWeiter = Console.ReadLine();
                int auswahlWeiter2 = int.Parse(auswahlWeiter);



                if (auswahlWeiter2 == 1) {


                    Console.WriteLine("An welcher stelle möchten sie ihre Nummer verwenden?\n[a]Erste Stelle\t[b]Zweite Stelle");
                    string auswahl2 = Console.ReadLine();


                    switch (auswahl2)
                    {


                        case "a":

                            Console.WriteLine("Enter your Operation\n[1]Addition\t[2]Subtraktion\t[3]Multiplikation\t[4]Division\t[5]Stop");
                            string Auswahl1 = Console.ReadLine();
                            int auswahl1 = int.Parse(Auswahl1);

                            if (auswahl1 == 5)
                            {
                                Console.WriteLine("Abruch...");

                                break;
                            }

                            switch (auswahl1)
                            {

                                case 1:
                                Console.WriteLine("Enter numbers:");
                                string A1 = Console.ReadLine();
                                int a1 = int.Parse(A1);
                                int b1 = operations.LastResult;
                                int result1 = Operations.Additon(a1, b1);
                                Console.WriteLine(a1 + "+" + b1 + "=" + result1);
                                operations.LastResult = result1;
                                break;

                            case 2:
                                Console.WriteLine("Enter numbers:");
                                string C1 = Console.ReadLine();
                                int c1 = int.Parse(C1);
                                int d1 = operations.LastResult;
                                int resultS1 = Operations.Subtraktion(c1, d1);
                                Console.WriteLine(c1 + "-" + d1 + "=" + resultS1);
                                operations.LastResult = resultS1;
                            break;

                            case 3:
                                Console.WriteLine("Enter numbers:");
                                string F1 = Console.ReadLine();
                                int f1 = int.Parse(F1);
                                int g1 = operations.LastResult;
                                int resultM1 = Operations.Multiplikation(g1, f1);
                                Console.WriteLine(g1 + "x" + f1 + "=" + resultM1);
                                operations.LastResult = resultM1;
                            break;

                            case 4:
                                Console.WriteLine("Enter numbers:");
                                string H1 = Console.ReadLine();
                                int h1 = int.Parse(H1);
                                int i1 = operations.LastResult;
                                int resultD1 = Operations.Division(h1, i1);
                                Console.WriteLine(h1 + ":" + i1 + "=" + resultD1);
                                operations.LastResult = resultD1;
                            break;

                            default:
                                Console.WriteLine("Falsche eingabe");
                                break;

                            }
                            
                        break;

                        case "b":


                            Console.WriteLine("Enter your Operation\n[1]Addition\t[2]Subtraktion\t[3]Multiplikation\t[4]Division\t[5]Stop");
                            string Auswahl2 = Console.ReadLine();
                            int auswahl3 = int.Parse(Auswahl2);

                            if (auswahl3 == 5)
                            {
                                Console.WriteLine("Abruch...");

                                break;
                            }

                            switch (auswahl3)
                            {
                                case 1:
                                    Console.WriteLine("Enter numbers:");
                                    string B2 = Console.ReadLine();
                                    int a2 = operations.LastResult;
                                    int b2 = int.Parse(B2);
                                    int result2 = Operations.Additon(a2, b2);
                                    Console.WriteLine(a2 + "+" + b2 + "=" + result2);
                                    operations.LastResult = result2;
                                    break;

                                case 2:
                                    Console.WriteLine("Enter numbers:");
                                    string D2 = Console.ReadLine();
                                    int c2 = operations.LastResult;
                                    int d2 = int.Parse(D2);
                                    int resultS2 = Operations.Subtraktion(c2, d2);
                                    Console.WriteLine(c2 + "-" + d2+ "=" + resultS2);
                                    operations.LastResult = resultS2;
                                    break;

                                case 3:
                                    Console.WriteLine("Enter numbers:");
                                    string G2 = Console.ReadLine();
                                    int f2 = operations.LastResult;
                                    int g2 = int.Parse(G2);
                                    int resultM2 = Operations.Multiplikation(g2, f2);
                                    Console.WriteLine(g2 + "x" + f2 + "=" + resultM2);
                                    operations.LastResult = resultM2;
                                    break;

                                case 4:
                                    Console.WriteLine("Enter numbers:");
                                    string I2 = Console.ReadLine();
                                    int h2 = operations.LastResult;
                                    int i2 = int.Parse(I2);
                                    int resultD2 = Operations.Division(h2, i2);
                                    Console.WriteLine(h2 + ":" + i2 + "=" + resultD2);
                                    operations.LastResult = resultD2;
                                    break;

                                default: Console.WriteLine("Falsche eingabe");
                                    break;
                            }
                        break;
                    }

                    break;

                }
                break;

                if(auswahlWeiter2 == 2)
                {
                    Console.WriteLine("Abruch...");
                    break;
                }


            }
                        

                
                    
        }
            
    }
}