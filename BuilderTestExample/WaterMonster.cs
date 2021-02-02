namespace BuilderTestExample
{
    class WaterMonster : MonsterGenerate
    {
        public WaterMonster()

        {
            monster = new Monster("Water");
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
            monster["power"] = "Symphony of marine divinity";
        }
        public override void GenerateDebility()
        {

            monster["debility"] = "Dragon";
        }
        public override void GenerateHealth()
        {
            monster["health"] = "83HP";
        }
        public override void GenerateAttackPower()
        {
            monster["attack power"] = "74AP";
        }

    }
}
