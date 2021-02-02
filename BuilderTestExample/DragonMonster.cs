namespace BuilderTestExample
{
    class DragonMonster : MonsterGenerate
    {
        public DragonMonster()

        {
            monster = new Monster("Dragon");
        }

        public override void GenerateNature(string nature)
        {
            monster["nature"] = nature;
        }

        public override void GenerateSex(string sex)
        {
            monster["sex"] = sex;
        }

        public override void GenerateName(string name)
        {
            monster["name"] = name;
        }
        public override void GeneratePower()
        {
            monster["power"] = "Dragon Pulse";
        }
        public override void GenerateDebility()
        {

            monster["debility"] = "Steel";
        }
        public override void GenerateHealth()
        {
            monster["health"] = "202HP";
        }
        public override void GenerateAttackPower()
        {
            monster["attack power"] = "132AP";
        }
    }
}
