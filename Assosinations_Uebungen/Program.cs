namespace Assosinations_Uebungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vater papa = new Vater(); 
            Kind child = new Kind();    
            Console.WriteLine("Hello, World!");

            papa.SetKind(child);
            child.SetVater(papa);
            Hund hund = new Hund();

            Laus laus = new Laus(hund);
            Laus laus2 = new Laus(hund);

            int i = 0;

            
           
        }
    }
}