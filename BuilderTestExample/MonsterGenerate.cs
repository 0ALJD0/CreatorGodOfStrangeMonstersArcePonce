using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderTestExample
{
    abstract class MonsterGenerate
    {
        protected Monster monster;

        public Monster Monster
        {

            get { return monster; }

        }

        public abstract void GenerateNature(string nature);

        public abstract void GeneratePower();

        public abstract void GenerateName(string name);

        public abstract void GenerateHealth();

        public abstract void GenerateSex(string sex);

        public abstract void GenerateAttackPower();

        public abstract void GenerateDebility();
    }
}
