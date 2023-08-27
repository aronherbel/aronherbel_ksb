
using System.Linq.Expressions;

namespace OO_Functions
{
    internal class Program
    {
        static int[] ReadNumbersFromConsole(int count)
        {
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Bitte geben Sie Zahl {i + 1} ein:");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            return numbers;
        }
        static void Main(string[] args)
        {
            

            do
            {
                
                Console.WriteLine("\nWas möchten sie berechnen ggT[1]\nkgv[2]\nggT_r[3]\nmehrere Zahlen verwenden[4]");
                string auswahl1 = Console.ReadLine();
                int auswahl = int.Parse(auswahl1);


                switch (auswahl)
                {
                    case 1:
                        string operation_ggt = "ggt";
                        int numOne_ggt = MyMath.ReadInt();
                        int numTwo_ggt = MyMath.ReadInt();

                        int result_ggt = MyMath.Calc_ggt(numOne_ggt, numTwo_ggt);

                        MyMath.ShowResult(operation_ggt, numOne_ggt, numTwo_ggt, result_ggt);

                        Console.WriteLine("Wollen sie die Zahlen tauschen?\nJa[1]\nNein[2]");
                        string wahl1 = Console.ReadLine();
                        int wahl = int.Parse(wahl1);

                        switch (wahl) 
                        { 
                            case 1:
                                //Hier erhalte ich Fehler
                                //int umgekehrt = MyMath.Swap(ref numOne_ggt, ref numTwo_ggt);
                                break;
                            case 2:
                            Console.WriteLine("Oke");
                                break;
                        }

                        break;

                    case 2:
                        string operation_kgv = "kgv";
                        int numOne_kgv = MyMath.ReadInt();
                        int numTwo_kgv = MyMath.ReadInt();

                        int result_kgv = MyMath.Calc_kgv(numOne_kgv, numTwo_kgv);

                        MyMath.ShowResult(operation_kgv, numOne_kgv, numTwo_kgv, result_kgv);

                        break;

                    case 3:
                        string operation_ggtr = "ggt_r";
                        int numOne_ggtr = MyMath.ReadInt();
                        int numTwo_ggtr = MyMath.ReadInt();

                        int result_ggtr = MyMath.Calc_kgv(numOne_ggtr, numTwo_ggtr);

                        MyMath.ShowResult(operation_ggtr, numOne_ggtr, numTwo_ggtr, result_ggtr);

                        break;

                    case 4:
                        Console.WriteLine("Geben sie die länge ihres zahles ein");
                        string count1 = Console.ReadLine();
                        int count = int.Parse(count1);

                        int[] numbers = Program.ReadNumbersFromConsole(count);

                        Console.WriteLine("Was möchtest du berechnen Mittelwert[1]\nkleinste Zahl[2]\ngrösste Zahl[3]\numkehren[4]");
                        string auswahl2 = Console.ReadLine();
                        int auswahl3 = int.Parse(auswahl2);

                        switch (auswahl3)
                        {
                            case 1:
                                double mittelwert = MyMath.Calc_Mittelwert(numbers);
                                Console.WriteLine($"Resultat beträgt {mittelwert}");
                                break;

                            case 2:
                                int kleinste = MyMath.Calc_KleinsterWert(numbers);
                                Console.WriteLine($"Resultat beträgt {kleinste}");
                                break;

                            case 3:
                                double biggest = MyMath.Calc_GroessterWert(numbers);
                                Console.WriteLine($"Resultat beträgt {biggest}");
                                break;
                                
                                case 4:
                                // hier erhalt ich fehler:
                                // double reverse = MyMath.ReverseArray(numbers);
                                Console.WriteLine($"Resultat beträgt {reverse}");
                                break;
                        }

                        break;
                }
            } while (true);






        }
    }
}

