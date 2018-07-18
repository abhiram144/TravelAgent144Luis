using Microsoft.Bot.Builder.FormFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleEchoBot.Models
{
    [Serializable]
    public class TravelBooking
    {
        [Prompt("Please enter From where you are planning to travel")]
        public string FromLocation { get; set; }

        [Prompt("Oh Vokaay Human ... Got it .... please tell me where you want to go")]
        public string ToLocation { get; set; }

        [Prompt("Its good to see you explore the world ...... Do you want to go by bus or flight?")]
        public string TravelType { get; set; }

        [Prompt("when you want to travel")]
        public string DateOfTravel { get; set; }

        public string Class { get; set; }

        public DateTime ConvertedDateTime { get; set; }
    }
}