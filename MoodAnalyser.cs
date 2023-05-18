﻿using System;
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
                if (message == null)
                {
                    throw new MoodAnalyzerException("Invalid mood");
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
            catch (MoodAnalyzerException)
            {
                return "HAPPY";
            }
        }
    }
}
