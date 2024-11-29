namespace Functions
{
    internal class Program
    {
        string[] vragen = new string[] {
            "test vraag1",
            "testvraag2"
        };
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        internal string GetVraag(int vraagIndex)
        {
            return vragen[vraagIndex];
        }
        internal void Run()
        {

            Console.WriteLine("This is functioning!");
            Console.WriteLine("");
            Console.WriteLine("Dit is nu de start van mijn programma.");
            //vraag1();
            //vraag2();
            //vraag3();
            //vraag4();
            //vraag5();
            //vraag6();
            //vraag7();
        }
        internal void vraag1()
        {

            Console.WriteLine("How long would you'd survive a zombie apocalypse?");
            string antwoord = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Antwoord:");

            Console.WriteLine(antwoord);

            Console.WriteLine("");

        }
        internal void vraag2()
        {

            Console.WriteLine("Do you like cheeseburgers?");
            string antwoord = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Antwoord:");

            Console.WriteLine(antwoord);

            Console.WriteLine("");


        }
        internal void vraag3()
        {

            Console.WriteLine("Do you like waffles?");
            string antwoord = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Antwoord:");

            Console.WriteLine(antwoord);

            Console.WriteLine("");


        }
        internal void vraag4()
        {

            Console.WriteLine("That's cool, what colour do you like :D ?");
            string antwoord = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Antwoord:");

            Console.WriteLine(antwoord);

            Console.WriteLine("");


        }

        internal void vraag5()
        {

            Console.WriteLine("I like eating candle wax. Do you also enjoy eating candle wax?");
            string antwoord = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Antwoord:");

            Console.WriteLine(antwoord);

            Console.WriteLine("");


        }
        internal void vraag6()
        {

            Console.WriteLine("Thank you for these answers, you may now type something to give the last answer.");
            string antwoord = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Antwoord:");

            Console.WriteLine(antwoord);

            Console.WriteLine("");


        }
        internal string vraag7()
        {
            Console.WriteLine("hi");
            string antwoord = vraag7();
            Console.WriteLine(antwoord); 

            return antwoord;
        }

    }
}
