using MoodAnalyserDemo;
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

        //I am in any mood returns happy 
        [Test]
        public void GivenAnyMood_ShouldReturnHappy()
        {
            MoodAnalyze moodAnalyse = new MoodAnalyze("I am in Any Mood");
            string result = moodAnalyse.AnalyzeMood();
            Assert.AreEqual(result, "Happy");
        }
        [Test]
        public void GivenNullMood_ShouldReturnHappy()
        {
            MoodAnalyze moodAnalyse = new MoodAnalyze(null);
            string result = moodAnalyse.AnalyzeMood();
            Assert.AreEqual(result, "Happy");

        }
        [Test]
        public void GivenNullMessage_ShouldThrowCustomNullException()
        {
            try
            {
                MoodAnalyze moodAnalyse = new MoodAnalyze(null);
                string result = moodAnalyse.AnalyzeMood();



            }
            catch (MoodAnalyseCustom_Exception ex) 
            {
                Assert.AreEqual(ex.Message, "Message should not be null");
            }
        }

    }
}

