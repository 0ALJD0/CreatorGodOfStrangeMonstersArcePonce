namespace BuilderTestExample
{
    class SteelMonster : MonsterGenerate
    {
        public SteelMonster()

        {

            monster = new Monster("Steel");

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
            monster["power"] = "Metal Claw";
        }
        public override void GenerateDebility()
        {

            monster["debility"] = "Fuego";
        }
        public override void GenerateHealth()
        {
            monster["health"] = "165HP";
        }
        public override void GenerateAttackPower()
        {
            monster["attack power"] = "109AP";
        }
    }
}
