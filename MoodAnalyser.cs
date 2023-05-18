using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    internal class MoodAnalyser
    {
        private string message;
        public MoodAnalyser()
        {
            message = "";
        }

        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            try
            {
                if (message == null || message.Trim().Equals(""))
                {
                    throw new MoodAnalyzerException("Invalid mood: Mood cannot be null or empty");
                }

                if (message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (MoodAnalyzerException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
                return "HAPPY";
            }
        }
    }
}
