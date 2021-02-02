namespace BuilderTestExample
{
    class FireMonster : MonsterGenerate
    {
        public FireMonster()

        {

            monster = new Monster("Fire");

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
            monster["power"] = "Flamethrower";
        }
        public override void GenerateDebility()
        {

            monster["debility"] = "Water";
        }
        public override void GenerateHealth()
        {
            monster["health"] = "155HP";
        }
        public override void GenerateAttackPower()
        {
            monster["attack power"] = "108AP";
        }
    }
}
