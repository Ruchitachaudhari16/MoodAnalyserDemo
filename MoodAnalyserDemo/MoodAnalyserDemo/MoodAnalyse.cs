using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
