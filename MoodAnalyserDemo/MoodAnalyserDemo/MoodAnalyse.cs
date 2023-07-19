using MoodAnalyserDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoodAnalyserDemo.MoodAnalyseCustom_Exception;

namespace MoodAnalyzerDemo
{
    public class MoodAnalyze
    {
        string message;

        public MoodAnalyze(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyseCustom_Exception("Message should not be empty", MoodAnalyser_ExceptionType.EMPTY_MOOD);
                }
                //My name is sad
                if (message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch(NullReferenceException)
            {
               // return "Happy";
               throw new MoodAnalyseCustom_Exception("Message should not be null", MoodAnalyser_ExceptionType.EMPTY_MOOD); //MoodAnalyser_ExceptionType.NULL_MOOD-Enum call.
            }

        }
    }
}
