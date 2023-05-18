namespace MoodAnalyserProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Mood Analyser Problem");

            string message1 = "I am in Sad Mood";
            MoodAnalyser moodAnalyzer1 = new MoodAnalyser(message1);
            string mood1 = moodAnalyzer1.AnalyzeMood();
            Console.WriteLine("Mood: " + mood1); 

            // Test Case 2
            string message2 = "I am in Any Mood";
            MoodAnalyser moodAnalyzer2 = new MoodAnalyser(message2);
            string mood2 = moodAnalyzer2.AnalyzeMood();
            Console.WriteLine("Mood: " + mood2); 
        }
    }
}