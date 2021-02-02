//3ro
//usamos esta librería para el uso del sistema(consola,etc)
using System;
//usamos esta librería para el uso de la clase Dictionary
//el cual crea un Anidado de Arrays, y nos permite movernos por él
//mediante el nombre o valor del array al que queramos acceder
//en este caso serán todos de tipo String
using System.Collections.Generic;

// PRODUCTO
namespace BuilderTestExample
{   
    /*
     * Creamos la clase Monster(Producto)
     */
    class Monster
    {
        //declaramos la variable tipo string _monsterType  que es el tipo de monstruo.
        private string _monsterType;
        //Creamos el objeto _dictionary(diccionario)
        private Dictionary<string, string> _dictionary =
          new Dictionary<string, string>();
        //este asignará el tipo de monstruo que se asigne desde la clase hija(Constructores Específicos)
        public Monster(string monsterType)
        {
            this._monsterType = monsterType;
        }
        /*
         * Este es el índice, el cuál permitirá que desde la clase hija
         * se asignen valores en los arrays con la estructura:
         * monster["nombre del atributo"]=v"alor del atributo"
         */
        public string this[string key]

        {
            get { return _dictionary[key]; }

            set { _dictionary[key] = value; }

        }
        /*
         * Este metodo permitirá visualizar el producto
         * el cuál está ordenado de forma que se muestren
         * primero el tipo de monstruo
         * luego los atributos elejidos por el usuario
         * y por ultimo los atributos únicos de cada tipo de dragón(clases hijas/Constructores Específicos)
         */
        public void Show()

        {
            Console.WriteLine("\n---------------------------");

            Console.WriteLine("Monster Type: {0}", _monsterType);

            Console.WriteLine(" Nature : {0}", _dictionary["nature"]);

            Console.WriteLine(" Power : {0}", _dictionary["power"]);

            Console.WriteLine(" Name: {0}", _dictionary["name"]);

            Console.WriteLine(" Health : {0}", _dictionary["health"]);

            Console.WriteLine(" Sex : {0}", _dictionary["sex"]);

            Console.WriteLine(" Attack Power : {0}", _dictionary["attack power"]);

            Console.WriteLine(" Debility : {0}", _dictionary["debility"]);
        }
    }
}
