using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem_3M.Models;
using TestSystem_3M.Data;
using System.Windows.Navigation;
using TestSystem_3M.Models.ViewModels;

namespace TestSystem_3M.Services
{
    // бизнес логика
    public class TestSystemService
    {
        private List<Question> questions;

        public User User { get; }

        public Result Result { get; }

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

        public int QuestionCount
        {
            get { return questions.Count; }
        }

        public TestSystemService()
        {
            var dbQuestions = DataAccessLayer.GetQuestions();
            if (dbQuestions != null)
            {
                questions = dbQuestions;
            }
            else
            {
                questions = new List<Question>();
            }
            User = DataAccessLayer.GetFirstUser();
            User.Results = new List<Result>();

            Result = new Result();
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

        public void SaveResultToDb(DateTime startDateTime, DateTime endDateTime)
        {
            Result.UserId = User.Id;
            Result.User = User;
            Result.StartDateTime = startDateTime;
            Result.EndDateTime = endDateTime;
            Result.Scores = Score;
            Result.MaxScores = QuestionCount;

            User.Results.Add(Result);

            DataAccessLayer.SaveResultToDb(Result);
        }

        public List<ViewModelResultUser> GetViewModelResultUsers()
        {
            return DataAccessLayer.GetViewModelResultUsers(User.Id);
        }

        public bool SignIn(string login, string password)
        {
            return DataAccessLayer.SigIn(login, password) != null;
        }

        public bool SignUp(string login, string password)
        {
            return DataAccessLayer.SigUp(login, password);
        }
    }
}
