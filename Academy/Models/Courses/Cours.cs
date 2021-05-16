using Academy.Models.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Academy.Models.Courses
{
    public class Cours
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Полето \"Област на обучение\" е задължително")]
        public string Area { get; set; }


        [Required(ErrorMessage = "Полето \"Тема урока\" е задължително")]
        public string Theme { get; set; }


        [Required(ErrorMessage ="Полето \"Времетраене\" е задължително")]
        [Range(1, 3000, ErrorMessage = "Полето \"Времетраене\" трябва да бъде между 1 и 3000")]
        public int Time { get; set; }


        public string TeacherId { get; set; }
        public AcademyUser Teacher { get; set; }
    }
}
