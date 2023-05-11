using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TestSystem_3M.Models.ViewModels
{
    public class ViewModelResultUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Score { get; set; }
        public int MaxScore { get; set; }
        public string StartDateTime { get; set; }
        public string EndDateTime { get; set; }
    }
}