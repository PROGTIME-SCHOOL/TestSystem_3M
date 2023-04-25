using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSystem_3M.Models;

namespace TestSystem_3M.Data
{
    public static class DataAccessLayer
    {
        public static List<Question> GetQuestions()
        {
            TestSystemContext context = new TestSystemContext();

            return context.Question.ToList();
        }
    }
}
