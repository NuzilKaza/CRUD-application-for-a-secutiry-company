using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Entities
{
    class House : Entity
    {
        private int id;
        private string address;
        private byte floorsCount;
        private string type;

        public House(int id, string address, byte floorsCount, string type)
        {
            this.id = id;
            this.address = address;
            this.floorsCount = floorsCount;
            this.type = type;
        }

        public int Id { get => id; }
        public string Address { get => address; }
        public byte FloorsCount { get => floorsCount; }
        public string Type { get => type; }
    }
}
