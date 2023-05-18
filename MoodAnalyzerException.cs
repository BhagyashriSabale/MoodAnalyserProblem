using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    internal class MoodAnalyzerException:Exception
    {
        public enum ExceptionType
        {
            NULL_MOOD,
            EMPTY_MOOD
        }

        public ExceptionType Type { get; }
        public MoodAnalyzerException(string message, ExceptionType type) : base(message)
        {
            Type = type;
        }
    }
}
