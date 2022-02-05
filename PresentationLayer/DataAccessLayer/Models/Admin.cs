using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Models
{
    public class Admin
    {
        public int Admin_Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public override string ToString() 
        {
            return (Admin_Id + " " + Name + " " + Surname + " " + Username + " " + Password);
        }
    }
}
