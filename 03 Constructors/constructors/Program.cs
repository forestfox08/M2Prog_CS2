namespace constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(":3c hehe");
        }

        class QuizVraag
        {
            internal string vraag;
            internal string antwoord;
        }
        internal QuizVraag(string vraag, string antwoord)
        {
            this.vraag = vraag;
            this.antwoord = antwoord;
        }
        private void Run()
        {
            QuizVraag quizVraag = new QuizVraag("Question!", "Answer.");
        }
            class Quiz
            {
                internal QuizVraag[] vragen;
                internal QuizVraagAntwoord[] ingevuldeAntwoorden;
            }
        }
    }
}
