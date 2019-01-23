using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Entities
{
    class Contract : Entity
    {
        private int id;
        private Apartment apartment;
        private int payment; // Payment per month in rubles
        private int compensation; // In rubles
        private int fine; // in rubles
        private DateTime commencementDate;
        private DateTime expirationDate;
        private DateTime extensionDate;
        private string additionalConditions;

        public Contract(int id, Apartment apartment, int payment, int compensation, 
            int fine, DateTime commencementDate, DateTime expirationDate)
        {
            this.id = id;
            this.apartment = apartment;
            this.payment = payment;
            this.compensation = compensation;
            this.fine = fine;
            this.commencementDate = commencementDate;
            this.expirationDate = expirationDate;
        }

        public int Id { get => id; }
        public int Payment { get => payment; }
        public int Compensation { get => compensation; }
        public int Fine { get => fine; }
        public DateTime CommencementDate { get => commencementDate; }
        public DateTime ExpirationDate { get => expirationDate; }
        public DateTime ExtensionDate { get => extensionDate; set => extensionDate = value; }
        public string AdditionalConditions { get => additionalConditions; set => additionalConditions = value; }
        internal Apartment Apartment { get => apartment; }
    }
}
