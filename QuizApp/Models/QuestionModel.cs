﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace QuizApp.Models
{
    public class QuestionModel
    {
        public int Id { get; set; }
        [Required]
        public string Question { get; set; }
        [Required]
        public string CorrectAnswer { get; set; }

        public ICollection<AnswerModel> Answers { get; set; }
        public QuizModel Quiz { get; set; }
        public QuizCategoryModel QuizCategory { get; set; }
    }
}