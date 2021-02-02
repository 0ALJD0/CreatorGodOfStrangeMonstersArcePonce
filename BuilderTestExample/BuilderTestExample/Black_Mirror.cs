/*
    Universidad Laica Eloy Alfaro 
Nombre: Bryan Alejandro Arce Ponce
Curso: Tercer Semestre A
Año lectivo: 2020(2)
 */


using System;
namespace BuilderTestExample
{   
    /*
     * 6to
     * CLIENTE
     */
    class Black_Mirror
    {

        static void Main(string[] args)
        {

            int n;
            string k;

            //Repetición sí el usuario lo indica
            do
            {
                //Presentación y elección del tipo de monstruo.
                Console.WriteLine(" Welcome to \"Black Mirror\"");
                Console.WriteLine(" I'm the summoner of monsters");
                Console.WriteLine(" Do you want to get your first monster?");
                Console.WriteLine(" Well, first choose the dragon type ");
                Console.WriteLine(" well, first choose the desired type of dragon");
                Console.WriteLine(" Steel ===== 1");
                Console.WriteLine(" Dragon ===== 2");
                Console.WriteLine(" Water ===== 3");
                Console.WriteLine(" Fire ===== 4");
                Console.WriteLine(" Please, write the number and then press Enter");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                //Pregunta para continuar, para cada una de las alternaticas
                switch (n)
                {
                    case 1:
                        Console.WriteLine(" You have selected Steel type.\n" +
                        "Do you want to change selection?");
                        break;
                    case 2:
                        Console.WriteLine(" You have selected Dragon type.\n" +
                        "Do you want to change selection?");
                        break;
                    case 3:
                        Console.WriteLine(" You have selected Water type.\n" +
                        "Do you want to change selection?");
                        break;
                    case 4:
                        Console.WriteLine(" You have selected Fire type.\n" +
                        "Do you want to change selection?");
                        break;
                }
                Console.WriteLine("Enter \"Y\" equal yes or \"N\" equal no");
                k = Console.ReadLine();
                Console.WriteLine("\n");
            } while (k == "Y" || k == "y");

            //Creación del tipo de monstruo elegido por el usuario.
            switch (n)
            {
                case 1:
                    Steel_Monster();
                    break;
                case 2:
                    Dragon_Monster();
                    break;
                case 3:
                    Water_Monster();
                    break;
                case 4:
                    Fire_Monster();
                    break;
            }



        }

        //Metodos para la creación de los difenrentes tipos de monstruo
        public static void Steel_Monster()
        {
            //Creamos nuestro objeto Summoner(Director)
            Summoner summoner = new Summoner();
            //Creamos el generador del tipo correspondiente(SteelMonster) dentro de la clase Constructor(MonsterGenerate)
            //Aquí el generator será el objeto que se va usar por medio del Director
            MonsterGenerate generator = new SteelMonster();

            string nature, name, sex;

            nature = Nature();

            name = Name();

            sex = Sex();

            Console.WriteLine("Congratulations!! You have a monster with the next stats:");

            //Agregamos los atributos que peermitirán la creación del Producto(Monstruo)
            summoner.Materializer(generator, nature, name, sex);

            //Mostramos el producto mediante la función que posee el objeto monster del generador.
            generator.Monster.Show();
        }
        public static void Dragon_Monster()
        {
            Summoner summoner = new Summoner();
            MonsterGenerate generator = new DragonMonster();

            string nature, name, sex;
            nature = Nature();

            name = Name();

            sex = Sex();

            Console.WriteLine("Congratulations!! You have a monster with the next stats:");
            summoner.Materializer(generator, nature, name, sex);
            generator.Monster.Show();
        }
        public static void Water_Monster()
        {
            Summoner summoner = new Summoner();
            MonsterGenerate generator = new WaterMonster();

            string nature, name, sex;

            nature = Nature();

            name = Name();

            sex = Sex();

            Console.WriteLine("Congratulations!! You have a monster with the next stats:");
            summoner.Materializer(generator, nature, name, sex);
            generator.Monster.Show();
        }
        public static void Fire_Monster()
        {
            Summoner summoner = new Summoner();
            MonsterGenerate generator = new FireMonster();

            string nature, name, sex;

            nature = Nature();

            name = Name();

            sex = Sex();

            Console.WriteLine("Congratulations!! You have a monster with the next stats:");
            summoner.Materializer(generator, nature, name, sex);
            generator.Monster.Show();
        }

        //Método para la selección de la naturaleza del monstruo.
        public static string Nature()
        {
            string nature;
            Console.WriteLine(" Now, choose the nature of you monster");
            Console.WriteLine(" Gentle == 1 \n Jolly == 2 \n Shy == 3 \n Fearful == 4");
            Console.WriteLine(" Please, write the number and then press Enter");
            nature = Console.ReadLine();
            Console.WriteLine("\n\n");

            switch (nature)
            {
                case "1":
                    nature = "Gentile";
                    break;
                case "2":
                    nature = "Jolly";
                    break;
                case "3":
                    nature = "Shy";
                    break;
                case "4":
                    nature = "Fearful";
                    break;
            }
            return nature;
        }

        //Metodo para la asignación del atributo nombre por parte del usuario.
        public static string Name()
        {
            string name;
            Console.WriteLine("Well, what name will you give it?");
            name = Console.ReadLine();
            Console.WriteLine("\n\n");

            return name;
        }

        //Método para la selección del sexo del monstruo por el usuario.
        public static string Sex()
        {
            string sex;
            Console.WriteLine("Finaly, choose your sex, yes... your sex ");
            Console.WriteLine("Male == M or Fermale == F");
            sex = Console.ReadLine();
            sex = sex.ToUpper();

            switch (sex)
            {
                case "M":
                    sex = "Male";
                    break;
                case "F":
                    sex = "Fermale";
                    break;
            }
            Console.WriteLine("\n\n");

            return sex;
        }
    }
    //El patrón de diseño Builder permite la organización eficiente del codigo cuando existen muchos atributos para una clase con objetos o bien este
    //genera mas y mas subclases con distintos atributos para el mismo objeto que se entregará. Y así tener un mejor orden en nuestro código, para que no nos
    //perdamos con muchos constructores sobrecargados...
}