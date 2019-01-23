using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Entities
{
    class Departure : Entity
    {
        private int id;
        private Crew crew;
        private Contract contract;
        private DateTime date;
        private bool isFalse;
        private string arrestDocument;

        public Departure(int id, Crew crew, Contract contract, DateTime date, bool isFalse)
        {
            this.id = id;
            this.crew = crew;
            this.contract = contract;
            this.date = date;
            this.isFalse = isFalse;
        }

        public int Id { get => id; }
        public DateTime Date { get => date; }
        public bool IsFalse { get => isFalse; }
        public string ArrestDocument { get => arrestDocument; set => arrestDocument = value; }
        internal Crew Crew { get => crew; }
        internal Contract Contract { get => contract; }
    }
}
