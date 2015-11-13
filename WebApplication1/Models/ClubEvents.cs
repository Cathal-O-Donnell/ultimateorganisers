using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ClubEvent
    {
        [Key]
        public int EventID { get; set; }

        [Display(Name = "Event Title")]
        public string EventTitle { get; set; }

        public DateTime EventDate { get; set; }

        public enum EventType { Meeting, Game, Training, Social, Other }

        [Display(Name ="Event Description")]
        public string EventDesc { get; set; }

    }//end ClubEvents
}//end Namespace