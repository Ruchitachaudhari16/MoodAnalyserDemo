using MoodAnalyzerDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzeTest
{
   
    public class MoodAnalyze_Test
    {
        
        [Test]
        public void GivenSadMood_ShouldReturnSad()
        {
            MoodAnalyze moodAnalyse = new MoodAnalyze("I am in Sad Mood");
            string result = moodAnalyse.AnalyzeMood();
            Assert.AreEqual(result, "Sad");
        }
       

    }
}

