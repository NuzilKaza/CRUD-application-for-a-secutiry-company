using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Entities
{
    public class Crew : Entity
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

        public string LeaderName { get => leaderName; set => leaderName = value; }
        public string CarModel { get => carModel; set => carModel = value; }
        public int Id { get => id; }
    }
}
