using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem_3M.Models;
using TestSystem_3M.Data;

namespace TestSystem_3M.Services
{
    // бизнес логика
    public class TestSystemService
    {
        private List<Question> questions;

        private int score;
        private int numQuestion;

        public int Score 
        { 
            get { return score; } 
        }

        public string CurrentQuestionContent
        {
            get { return questions[numQuestion].Content; }
        }

        public TestSystemService()
        {
            questions = new List<Question>();
        }

        public void SetQuestions(List<Question> questions)
        {
            this.questions = questions;
        }

        public bool CheckAnswer(string userAnswer)
        {
            bool bUserAnswer = userAnswer == "YES" ? true : false;

            if (questions[numQuestion].Answer == bUserAnswer)
            {
                score++;
            }

            if (numQuestion < questions.Count - 1)
            {
                numQuestion++;
            }
            else
            {
                // end
                return false;
            }

            return true;
        }
    }
}
