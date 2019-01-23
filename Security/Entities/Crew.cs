using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Entities
{
    class Crew : Entity
    {
        private int id;
        private string leaderName;
        private string carModel;

        public Crew(int id, string leaderName, string carModel)
        {
            this.id = id;
            this.leaderName = leaderName;
            this.carModel = carModel;
        }

        public string LeaderName { get => leaderName; }
        public string CarModel { get => carModel; }
        public int Id { get => id; }
    }
}
