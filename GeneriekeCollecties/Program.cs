using GeneriekeCollecties;
internal class Program
{
    private static void Main(string[] args)
    {
        Pile<int> p1 = new Pile<int>();
        char keuze = '0';
        do { 

            Console.WriteLine("Select your option:");
            Console.WriteLine("1 Add");
            Console.WriteLine("2 Remove");
            Console.WriteLine("3 Clear");
            Console.WriteLine("4 Print");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Enter choice now: ");
            keuze = (char)Console.Read();

            switch (keuze)
            {
                case '0':
                    break;
                case '1':
                    Console.WriteLine("Enter your input:");
                    p1.AddTo(Convert.ToInt32(Console.ReadLine()));
                    break;
                case '2':
                    if (p1.isLeeg())
                    {

                        Console.WriteLine("This row is empty.");

                    }
                    else
                        Console.WriteLine("The number you removed was: " + p1.RemoveFrom());
                    break;
                case '3':
                    p1.Clear();
                    Console.WriteLine("The row is cleared.");
                    break;
                case '4':
                    Console.WriteLine("All of the objects in your row:");
                    Console.Write(p1.ToString());
                    break;
            }

        } while (keuze != '0');
    }
}