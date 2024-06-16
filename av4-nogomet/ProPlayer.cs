using oop_av4_nogomet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace oop_av4_nogomet
{
     class ProPlayer:Player
    {
        public ProPlayer(double scoreProbability, IRandom random,  bool hasTrainingBonus) : base(scoreProbability, random)
        {
            this.hasTrainingBonus = hasTrainingBonus;
        }

        bool hasTrainingBonus;

        private double trainingBonus = 0.05;
       
        

        public override bool WillScore()
        {
            double bonusProbability = hasTrainingBonus ? random.GenerateDouble() * (trainingBonus) :
0.0;
             return random.GenerateDouble() < scoreProbability + bonusProbability;
        }
    }
}

