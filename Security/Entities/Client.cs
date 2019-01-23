using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Entities
{
    class Client : Entity
    {
        private int id;
        private string name;
        private string address;
        private string phone;

        public Client(int id, string name, string address, string phone)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }

        public int Id { get => id; }
        public string Name { get => name; }
        public string Address { get => address; }
        public string Phone { get => phone; }
    }
}
