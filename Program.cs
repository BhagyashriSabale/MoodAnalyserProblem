namespace MoodAnalyserProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Mood Analyser Problem");

            MoodAnalyser moodAnalyser1 = MoodAnalyzerFactory.CreateMoodAnalyzerObject("I am in Sad Mood");
            Console.WriteLine(moodAnalyser1.Equals(new MoodAnalyser("I am in Sad Mood")));
            try
            {
                MoodAnalyser moodAnalyser2 = MoodAnalyzerFactory.CreateMoodAnalyzerObject("I am in Sad Mood");
            }
            catch (MoodAnalyzerException ex)
            {
                Console.WriteLine("Exception: " + ex.Message); 
            }
            try
            {
                MoodAnalyser moodAnalyzer3 = MoodAnalyzerFactory.CreateMoodAnalyzerObject(" ");
            }
            catch (MoodAnalyzerException ex)
            {
                Console.WriteLine("Exception: " + ex.Message); // Output: No parameterized constructor found
            }
        }
    }
}