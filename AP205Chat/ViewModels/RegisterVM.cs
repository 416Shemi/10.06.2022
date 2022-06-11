using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AP205Chat.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string Fullname { get; set; }
        [Required]
        public string Username { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        public IFormFile Image { get; set; }
    }
}
