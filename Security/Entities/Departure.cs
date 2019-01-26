using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Entities
{
    public class Departure : Entity
    {
        private int id;
        private int crewId;
        private int contractId;
        private DateTime date;
        private bool isFalse;
        private string arrestDocument;

        public Departure(int id, int crewId, int contractId, DateTime date, bool isFalse)
        {
            this.id = id;
            this.crewId = crewId;
            this.contractId = contractId;
            this.date = date;
            this.isFalse = isFalse;
        }

        public int Id { get => id; }
        public DateTime Date { get => date; }
        public bool IsFalse { get => isFalse; }
        public string ArrestDocument { get => arrestDocument; set => arrestDocument = value; }
        public int CrewId { get => crewId; }
        public int ContractId { get => contractId; }
    }
}
