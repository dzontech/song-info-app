using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class BusinessPerfomer
    {
        private readonly PerformerRepository perfomer;

        public BusinessPerfomer()
        {
            this.perfomer = PerformerRepository.Instance;
        }

        //************************************ Methods for CRUD performers **************************************

        // Method for Get Perfomer
        public Performer GetPerformer(string name, string surname)
        {
            return this.perfomer.GetPerformer(name, surname);
        }

        // Method for Insert Performer
        public int InsertPerformer(string name, string surname)
        {
            return this.perfomer.InsertPerfomer(name, surname);
        }

        // Method for Update Performer
        public bool UpdatePerformer(Performer performer)
        {
            if (this.perfomer.UpdatePerformer(performer) > 0)
                return true;
            return false;
        }
    }
}
