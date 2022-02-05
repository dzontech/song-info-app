using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Models
{
    public class Song
    {
        public int Song_Id { get; set; }
        public Performer Performer { get; set; }
        public string Title { get; set; }
        public DateTime Created_At { get; set; }
        public string Picture_Url { get; set; }
        public string Genre { get; set; }
        public Admin Admin { get; set; }

        public decimal Jim_Rating { get; set; }

        public string Youtube_Url { get; set; }

        public override string ToString()
        {
            return Song_Id + "-" + Performer.ToString() + "-" + Title  + "-" + Genre + "-"+ Jim_Rating + "-" + Youtube_Url;
        }

    }
}
