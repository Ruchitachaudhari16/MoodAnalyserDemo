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
        MoodAnalyze moodAnalyse = new MoodAnalyze();
        [Test]
        public void GivenSadMood_ShouldReturnSad()
        {
            string result = moodAnalyse.AnalyzeMood("I am in Sad Mood");
            Assert.AreEqual(result, "Sad");
        }

    }
}
