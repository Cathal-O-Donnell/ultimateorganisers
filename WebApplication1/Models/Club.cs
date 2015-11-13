using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class UltimateDb : DbContext
    {
        public UltimateDb() : base("UltimateDb") { }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubEvent> ClubEvents { get; set; }
        public DbSet<ClubMember> ClubMembers { get; set; }
    }

        public class Club
    {
        // Class to manage a single Club
        [Key]
        public int ClubID { get; set; }

        [Display(Name = "Club Name")]
        public string ClubName { get; set; }

        [Display(Name = "Contact Email")]
        public string ClubEmail { get; set; }

        [Display(Name = "Description")]
        public string ClubDescription { get; set; } 

        //public enum ClubType { Sports, Recreational, Other }

        public virtual List<ClubMember> ClubMembers { get; set; } //List of users that are members of this Club **Ask David**

        public String ClubImage { get; set; }

    }//end Club
}//end Namespace