using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CompareAnswere
{
    public class Questions
    {
        string question;
        string trueFalse;

        public string Question { get => question; set => question = value; }

        public string TrueFalse { get => trueFalse; set => trueFalse = value; }

        public Questions(string question, string trueFalse)
        {
            this.question = question;
            this.trueFalse = trueFalse;
        }

        public Questions()
        {

        }
    }

    static class GetRandomQuestion
    {
        static Random random;
        static List<Questions> qa;
        static int numQuestion;

        static public List<Questions> QA => qa;

        static public int NumQuestion => numQuestion;

        static public string GetQuestion()
        {
            random = new Random();
            qa = new List<Questions>(File.Deserialize());
            numQuestion = random.Next(0, qa.Count());
            return qa[numQuestion].Question;
        }
    }

    static class Compare
    {
        static string answer;

        static string Answer { get => answer; set => answer = value; }

        static public bool Answers(string myAnswer)
        {
            Answer = GetRandomQuestion.QA[GetRandomQuestion.NumQuestion].TrueFalse;
            return (myAnswer == "+" && Answer == "true") || (myAnswer == "-" && Answer == "false") ? true : false;
        }
    }

    static class File
    {
        static string fileName = "questions.xml";

        static Random random = new Random();
        

        //static public void Serialize(List<Questions> questions)
        //{
        //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Questions>));
        //    Stream streamReader = new FileStream(fileName, FileMode.Create, FileAccess.Write);
        //    xmlSerializer.Serialize(streamReader, questions);
        //    streamReader.Close();
        //}

        static public List<Questions> Deserialize()
        {
            List<Questions> questions = new List<Questions>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Questions>));
            Stream streamReader = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            questions = (List<Questions>)xmlSerializer.Deserialize(streamReader);
            streamReader.Close();
            return questions;
        }
    }
}
