namespace RijSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        Auto auto1 = new Auto()
        {
            automaat = true,
            kenteken = "TESTINGTEXT"
            kilometerStand = 12345,
            merk = "Mercedes"
        };

        Auto auto2 = new Auto()
        {
            automaat = false,
            kenteken = "TESTIN"
            kilometerStand = 54321,
            merk = "Aston_Martin"
        };
    }
}
