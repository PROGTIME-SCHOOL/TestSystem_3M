using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem_3M.Models;
using TestSystem_3M.Models.ViewModels;

namespace TestSystem_3M.Data
{
    public static class DataAccessLayer
    {
        private static TestSystemContext context = new TestSystemContext();

        public static List<Question> GetQuestions()
        {
            return context.Question.ToList();
        }

        public static User GetFirstUser()
        {
            return context.User.FirstOrDefault();
        }

        public static void SaveResultToDb(Result result)
        {
            context.Result.Add(result);
            context.SaveChanges();
        }

        public static List<ViewModelResultUser> GetViewModelResultUsers(int id = 1)
        {
            List<ViewModelResultUser> viewModelResultUsers = new List<ViewModelResultUser>();

            List<Result> results = context.User.Include(x => x.Results).
                FirstOrDefault(x => x.Id == id).Results.ToList();

            int num = 1;
            foreach (var item in results)
            {
                ViewModelResultUser vm = new ViewModelResultUser()
                {
                    Id = num,
                    UserName = item.User.Login,
                    Score = item.Scores,
                    MaxScore = item.MaxScores,
                    StartDateTime = item.StartDateTime.ToString(),
                    EndDateTime = item.EndDateTime.ToString(),
                };
                num++;

                viewModelResultUsers.Add(vm);
            }

            return viewModelResultUsers;
        }

        public static User SigIn(string login, string password)
        {
            return context.User.FirstOrDefault(x => x.Login == login && x.Password == password);
        }

        public static bool SigUp(string login, string password)
        {
            User user = new User()
            {
                Login = login,
                Password = password
            };

            if (context.User.FirstOrDefault(x => x.Login == login) != null)
            {
                return false;
            }

            context.User.Add(user);
            context.SaveChanges();
            return true;
        }
    }
}
