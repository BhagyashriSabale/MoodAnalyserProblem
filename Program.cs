namespace MoodAnalyserProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Mood Analyser Problem");

            MoodAnalyser moodAnalyser1 = MoodAnalyzerFactory.CreateMoodAnalyzerObject("MoodAnalyzer");
            Console.WriteLine(moodAnalyser1.Equals(new MoodAnalyser()));
            try
            {
                MoodAnalyser moodAnalyser2 = MoodAnalyzerFactory.CreateMoodAnalyzerObject("InvalidClassName");
            }
            catch (MoodAnalyzerException ex)
            {
                Console.WriteLine("Exception: " + ex.Message); 
            }
            try
            {
                MoodAnalyser moodAnalyser3 = MoodAnalyzerFactory.CreateMoodAnalyzerObject("MoodAnalyzerWithParam");
            }
            catch (MoodAnalyzerException ex)
            {
                Console.WriteLine("Exception: " + ex.Message); 
            }
        }
    }
}