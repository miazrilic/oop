using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_av4_nogomet
{
    class Player
    {
        protected double scoreProbability;
        protected IRandom random;

        public Player(double scoreProbability, IRandom random)
        {
            this.scoreProbability = scoreProbability;
            this.random = random;
        }
        public virtual bool WillScore() {
            return random.GenerateDouble() < scoreProbability;
                }
    }
}

