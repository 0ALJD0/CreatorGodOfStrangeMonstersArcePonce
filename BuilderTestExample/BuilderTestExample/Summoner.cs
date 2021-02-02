/* 1ero
 * CLASE DIRECTOR (INTERFAZ)
 *  Conocemos que atributos van hacer elegidos por el usuario desde la interfaz,
 *  ahora podemos crear nuestra clase Summoner(Invocador) que será nuestro director,
 *  el cuál le entregará a la clase abstracta MonsterGenerate los atributos.
 */

namespace BuilderTestExample
{
    class Summoner
    {
        /*
         *  Creamos la función Materializer(Materializador) que será nuestro constructor de la clase Summoner,
         *  y le agregamos como parametros, el monstergenerate que es el que le indicará a la clase MonsterGenerate
         *  (Constructor)cuál constructor específico usar, junto a los parametros que el usuarió elija.
         */
        public void Materializer(MonsterGenerate monstergenerate, string nature, string name, string sex)
        {
            /*
             * Aquí agregamos los métodos(atributos) que usará nuestra clase Constructora(MonsterGenerate) para
             * la creación del producto(Monster) apartir del tipo o constructor específico indicado en Materializer.
             */
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
