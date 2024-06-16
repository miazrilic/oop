using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace oop_av4_nogomet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRandom generator = new UniformRandomGenerator( new Random());
            Player player = new Player(0.8,generator);
            Player proPlayer = new ProPlayer(0.85,generator, true);
            int playerScores = 0;
            int proPlayerScores = 0;
            int attempts = 100;

            for(int i=0; i<attempts; i++)
            {
                playerScores +=  player.WillScore()? 1:0;
                proPlayerScores += proPlayer.WillScore()? 1 : 0;
            }
            Console.WriteLine($"The recreational player scored {playerScores} times in {attempts}.");
            Console.WriteLine($"The professional player scored {proPlayerScores} times in {attempts}.");

        }
    }
}
