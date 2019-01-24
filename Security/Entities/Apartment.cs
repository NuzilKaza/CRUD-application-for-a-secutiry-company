﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Entities
{
    class Apartment
    {
        private int id;
        private Client client;
        private House house;
        private int numberInHouse;
        private byte floor;
        private string doorType;
        private bool hasKeyCode;
        private bool hasBalcony;
        private string balconyType;

        public Apartment(int id, Client client, House house, int numberInHouse, 
            byte floor, string doorType, bool hasKeyCode, bool hasBalcony)
        {
            this.id = id;
            this.client = client;
            this.house = house;
            this.numberInHouse = numberInHouse;
            this.floor = floor;
            this.doorType = doorType;
            this.hasKeyCode = hasKeyCode;
            this.hasBalcony = hasBalcony;
        }

        public int Id { get => id; }
        public int NumberInHouse { get => numberInHouse; }
        public byte Floor { get => floor; }
        public string DoorType { get => doorType; }
        public bool HasKeyCode { get => hasKeyCode; }
        public bool HasBalcony { get => hasBalcony; }
        public string BalconyType { get => balconyType; set => balconyType = value; }
        internal Client Client { get => client; }
        internal House House { get => house; }
    }
}