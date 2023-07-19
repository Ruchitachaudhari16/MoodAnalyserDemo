using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserDemo
{
    //Custom exception are user defined exceptions use to customize the exception as per user needed
   public class MoodAnalyseCustom_Exception:Exception
    {
        //Creating enum 

        public enum MoodAnalyser_ExceptionType
        {
            NULL_MOOD,
            EMPTY_MOOD,
        }
        //Creating object for Enum
        public MoodAnalyser_ExceptionType type;
        //Base keyword is used to access member of a base class within a derived class.
        public MoodAnalyseCustom_Exception(string message,MoodAnalyser_ExceptionType type):base (message)
        {
            this.type = type;
        }


    }
}
