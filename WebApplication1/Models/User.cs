using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace WebApplication1.Models
{
    public class ClubMember
    {      
        [Key]
        public int UserId { get; set; }

        [Display(Name = "First Name")]
        public string UserFName { get; set; }

        [Display(Name = "Last Name")]
        public string UserLName { get; set; }

        [Display(Name = "Email")]
        public string UserEmail { get; set; }

        [Display(Name = "User Description")]
        public string UserDescription { get; set; }

        public string UserImage { get; set; } //Image

        public string UserPassword { get; set; }

        //Foreign Key for Club Id

    }//end User Class
}//end Namespace