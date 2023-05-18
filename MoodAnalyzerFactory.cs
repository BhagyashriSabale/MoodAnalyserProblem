using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    internal class MoodAnalyzerFactory
    {

        public static MoodAnalyser CreateMoodAnalyzerObject(string className)
        {
            try
            {
                Type type = Type.GetType(className);
                if (type == null)
                {
                    throw new MoodAnalyzerException("No such class found");
                }

                ConstructorInfo constructor = type.GetConstructor(new[] { typeof(string) });
                if (constructor == null)
                {
                    throw new MoodAnalyzerException("No parameterized constructor found");
                }

                MoodAnalyser moodAnalyser = (MoodAnalyser)constructor.Invoke(null);
                return moodAnalyser;
            }
            catch (Exception ex)
            {
                throw new MoodAnalyzerException("Error creating MoodAnalyser object: " + ex.Message);
            }
        }
        public static string InvokeAnalyzeMoodMethod(MoodAnalyser moodAnalyzer, string methodName)
        {
            try
            {
                Type type = typeof(MoodAnalyser);
                MethodInfo method = type.GetMethod(methodName);
                if (method == null)
                {
                    throw new MoodAnalyzerException("No such method found");
                }

                return (string)method.Invoke(moodAnalyzer, null);
            }
            catch (Exception ex)
            {
                throw new MoodAnalyzerException("Error invoking AnalyzeMood method: " + ex.Message);
            }
        }
    }
}
