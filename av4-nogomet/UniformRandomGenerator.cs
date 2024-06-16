using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_av4_nogomet
{
    public class UniformRandomGenerator : IRandom{
        private Random generator;

        public UniformRandomGenerator(Random generator) {
            this.generator = generator;
        }

        public double GenerateDouble() {
            return generator.NextDouble();
           }
    }
}
