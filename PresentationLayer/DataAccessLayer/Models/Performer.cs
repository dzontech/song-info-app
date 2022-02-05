using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Models
{
    public class Performer
    {
        public int  Performer_Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return Performer_Id + "-" + Name + "-" + Surname;
        }
    }
}
