using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerDemo
{
    public class MoodAnalyze
    {
        public string AnalyzeMood(string message)
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
