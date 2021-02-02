

namespace BuilderTestExample
{
    class Summoner
    {
        public void Materializer(MonsterGenerate monstergenerate, string nature, string name, string sex)
        {
            monstergenerate.GenerateNature(nature);

            monstergenerate.GeneratePower();

            monstergenerate.GenerateName(name);

            monstergenerate.GenerateHealth();

            monstergenerate.GenerateSex(sex);

            monstergenerate.GenerateAttackPower();

            monstergenerate.GenerateDebility();
        }

    }
}
