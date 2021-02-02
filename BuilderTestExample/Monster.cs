using System;
using System.Collections.Generic;

namespace BuilderTestExample
{
    class Monster
    {
        private string _monsterType;

        private Dictionary<string, string> _dictionary =
          new Dictionary<string, string>();

        public Monster(string monsterType)
        {
            this._monsterType = monsterType;
        }

        public string this[string key]

        {
            get { return _dictionary[key]; }

            set { _dictionary[key] = value; }

        }
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
