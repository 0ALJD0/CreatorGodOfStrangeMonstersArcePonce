namespace BuilderTestExample
{
    //5to
    //CLASES HIJAS/CONSTRUCTORES ESPECÍFICOS

    //Creamos la relación Herencia FireMonster : MonsterGenerate
    class FireMonster : MonsterGenerate
    {   
        //Este usa el diccionario y asigna el nombre de la variable con el tipo de monstruo
        public FireMonster()

        {

            monster = new Monster("Fire");

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

        //atributos propios del Constructor Específico (FireMonster)
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
