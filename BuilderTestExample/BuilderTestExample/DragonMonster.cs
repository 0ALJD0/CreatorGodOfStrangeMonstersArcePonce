namespace BuilderTestExample
{
    //5to
    //CLASES HIJAS/CONSTRUCTORES ESPECÍFICOS

    //Creamos la relación Herencia DragonMonster : MonsterGenerate
    class DragonMonster : MonsterGenerate
    {
        //Este usa el diccionario y asigna el nombre de la variable con el tipo de monstruo
        public DragonMonster()

        {
            monster = new Monster("Dragon");
        }

        //Entonces ahora sí implmentamos los metodos en la clase hija
        //donde haremos que se agreguen los atributos de nuestro monstruo
        //en el diccionario.

        //atributos elegidos por usuario

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

        //atributos propios del Constructor Específico (DragonMonster)
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
