/* 2do
 * CLASE CONSTRUCTOR
 */
namespace BuilderTestExample
{   /*
     * Creamos nuestra clase abstracta(No posee ninguna implmentación en sus metodos) MonsterGenerate
     */
    abstract class MonsterGenerate
    {
        // Creamos nuestro producto Monster que va usarse en cada clase hija 

        protected Monster monster;

        // Obtenemos la instancia(objeto) Monster en este caso el objeto será un "diccionario".
        public Monster Monster
        {

            get { return monster; }

        }
        // Definimos los metodos que se usarán en la clases hijas, para la creación de los atributos de nuestra objeto producto.
        public abstract void GenerateNature(string nature);

        public abstract void GeneratePower();

        public abstract void GenerateName(string name);

        public abstract void GenerateHealth();

        public abstract void GenerateSex(string sex);

        public abstract void GenerateAttackPower();

        public abstract void GenerateDebility();
    }
}
