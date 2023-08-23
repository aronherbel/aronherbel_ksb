namespace OO_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Was möchten sie berechnen ggT[1]/kgv[2]");
            string auswahl1 = Console.ReadLine();
            int auswahl = int.Parse(auswahl1);

            switch (auswahl)
            {
                case 1:
                    Console.WriteLine("Geben Sie bitte ihre erste Zahl ein");
                    string a_ggt = Console.ReadLine();
                    Console.WriteLine("Geben Sie bitte ihre zweite Zahl ein");
                    string b_ggt = Console.ReadLine();

                    int numOne_ggt = int.Parse(a_ggt);
                    int numTwo_ggt = int.Parse(b_ggt);

                    int result_ggt = MyMath.Calc_ggt(numOne_ggt, numTwo_ggt);

                    Console.WriteLine("Der ggT beträgt " + result_ggt);

                    break;

                case 2:
                    Console.WriteLine("Geben Sie bitte ihre erste Zahl ein");
                    string a_kgv = Console.ReadLine();
                    Console.WriteLine("Geben Sie bitte ihre zweite Zahl ein");
                    string b_kgv = Console.ReadLine();

                    int numOne_kgv = int.Parse(a_kgv);
                    int numTwo_kgv = int.Parse(b_kgv);

                    int result_kgv = MyMath.Calc_kgv(numOne_kgv, numTwo_kgv);

                    Console.WriteLine("Der kgv beträgt " + result_kgv);

                    break;
            }

            

        }
    }
}