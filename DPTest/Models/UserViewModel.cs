using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DPTest.Models
{
    public class UserViewModel
    {
        public UserViewModel()
        {

        }
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserMobile { get; set; }
        public string UserEmail { get; set; }
    }
}