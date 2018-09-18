﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizApp.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Category")]
        public string Name { get; set; }
        [DisplayName("Image")]
        public string ImagePath { get; set; }

        public ICollection<CategoryQuiz> CategoryQuiz { get; set; }
    }
}