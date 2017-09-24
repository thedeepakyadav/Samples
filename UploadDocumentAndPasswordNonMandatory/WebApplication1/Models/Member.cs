using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Member
    {
        public int MemberID;
        [Required(ErrorMessage = "Please Enter username")]
        [StringLength(100, MinimumLength = 3)]

        public string UserName;
         [StringLength(100, MinimumLength = 3)]

        [Required(ErrorMessage="Please Enter password")]
        [DataType(DataType.Password)]

        public string Password;
        //[Required(ErrorMessage = "Please Enter same password")]
        //[DataType(DataType.Password)]
        //[Compare("Password")]
        //public string ComparePassword;

    }
}