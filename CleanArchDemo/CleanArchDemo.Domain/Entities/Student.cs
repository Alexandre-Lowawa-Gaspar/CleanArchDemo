using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchDemo.Domain.Common;

namespace CleanArchDemo.Domain.Entities
{
    public sealed class Student:GeneralData        
    {
        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O campo deve conter de 3 à 50 caracteres")]
        public string? FatherName { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "O campo deve conter de 3 à 50 caracteres")]
        public string? MotherName { get; set; }
        public string FullName()
        {
            return FirstName + " " + LastName;
        }
        [Required(ErrorMessage = "O campo é obrigatório")]
        public Enrollment Matriculation { get; set; }
    }
}
