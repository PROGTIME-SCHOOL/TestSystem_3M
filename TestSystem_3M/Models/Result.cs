﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem_3M.Models
{
    public class Result
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime StartDateTime { get; set; } 
        public DateTime EndDateTime { get; set; } 
        public int Scores { get; set; }
        public int MaxScores { get; set; }

        [NotMapped]
        public int NumCurrentQuestion { get; set; } = 0;
    }
}
