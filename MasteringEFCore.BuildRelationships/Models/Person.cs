using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MasteringEFCore.BuildRelationships.Models
{
    public class Person
    {
        public string DisplayName { get; set; }

        [MinLength(6, ErrorMessage = "Username necessário 6 caracteres!")]
        [MaxLength(6, ErrorMessage = "Username não pode exceder 30 caracteres")]
        public string Username { get; set; }

        public string PasswordHash { get; set; }

        [EmailAddress(ErrorMessage = "E-mail inválido!")]
        public string Email { get; set; }

        [Url(ErrorMessage = "URl inválida!")]
        public string Url { get; set; }
    }
}
