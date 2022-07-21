using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveInRealProject.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
       
        [Required(ErrorMessage = "Please enter your lastname")]
        public string LastName { get; set; }
       
        [Required(ErrorMessage = "Please enter your username")]
        public string Username { get; set; }
        

        [Required(ErrorMessage = "Please enter your mail")]
        public string Mail { get; set; }
        
        [Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Please enter your repeat password")]
        [Compare("Password",ErrorMessage = "Please make sure the passwords match")]
        public string ConfirmPassword { get; set; }




    }
}
