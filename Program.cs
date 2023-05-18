namespace MoodAnalyserProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Mood Analyser Problem");

            MoodAnalyser moodAnalyzer1 = MoodAnalyzerFactory.CreateMoodAnalyzerObject("I am in Happy Mood");
            string mood1 = MoodAnalyzerFactory.InvokeAnalyzeMoodMethod(moodAnalyzer1, "AnalyzeMood");
            Console.WriteLine(mood1);
            try
            {
                MoodAnalyser moodAnalyzer2 = MoodAnalyzerFactory.CreateMoodAnalyzerObject("I am in Happy Mood");
                string mood2 = MoodAnalyzerFactory.InvokeAnalyzeMoodMethod(moodAnalyzer2, "InvalidMethodName");
            }
            catch (MoodAnalyzerException ex)
            {
                Console.WriteLine("Exception: " + ex.Message); // Output: No such method found
            }
        }
    }
}