using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MoodAnalyserProblem
{
    internal class MoodAnalyzerException:Exception
    {
        public MoodAnalyzerException(string message) : base(message)
        {
        }
    }
}
