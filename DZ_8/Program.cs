using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_8
{
    class City
    {
        private int population;

        public int Population
        {
            get { return population; }
            set { population = value; }
        }

        public static City operator +(City city, int increase)
        {
            city.Population += increase;
            return city;
        }

        public static City operator -(City city, int decrease)
        {
            city.Population -= decrease;
            return city;
        }

        public static bool operator ==(City city1, City city2)
        {
            return city1.Population == city2.Population;
        }

        public static bool operator !=(City city1, City city2)
        {
            return city1.Population != city2.Population;
        }

        public static bool operator >(City city1, City city2)
        {
            return city1.Population > city2.Population;
        }

        public static bool operator <(City city1, City city2)
        {
            return city1.Population < city2.Population;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            City other = (City)obj;
            return this.Population == other.Population;
        }
    }

    class MorseCodeConverter
    {
        public string ConvertToMorseCode(string text)
        {
            Dictionary<char, string> morseCodes = new Dictionary<char, string>()
        {
            {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."},
            {'E', "."}, {'F', "..-."}, {'G', "--."}, {'H', "...."},
            {'I', ".."}, {'J', ".---"}, {'K', "-.-"}, {'L', ".-.."},
            {'M', "--"}, {'N', "-."}, {'O', "---"}, {'P', ".--."},
            {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
            {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"},
            {'Y', "-.--"}, {'Z', "--.."}
        };

            StringBuilder morseText = new StringBuilder();
            foreach (char c in text.ToUpper())
            {
                if (morseCodes.ContainsKey(c))
                {
                    morseText.Append(morseCodes[c] + " ");
                }
                else if (c == ' ')
                {
                    morseText.Append("/ ");
                }
            }

            return morseText.ToString();
        }
    }

    class MusicalInstrument
    {
        protected string name;

        public MusicalInstrument(string name)
        {
            this.name = name;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Making sound of the musical instrument");
        }

        public void Show()
        {
            Console.WriteLine("Musical Instrument: " + name);
        }

        public void Desc()
        {
            Console.WriteLine("Description of the musical instrument");
        }

        public void History()
        {
            Console.WriteLine("History of the musical instrument");
        }
    }

    class Violin : MusicalInstrument
    {
        public Violin(string name) : base(name) { }

        public override void Sound()
        {
            Console.WriteLine("Making sound of the Violin");
        }
    }

    class Trombone : MusicalInstrument
    {
        public Trombone(string name) : base(name) { }

        public override void Sound()
        {
            Console.WriteLine("Making sound of the Trombone");
        }
    }

    class Ukulele : MusicalInstrument
    {
        public Ukulele(string name) : base(name) { }

        public override void Sound()
        {
            Console.WriteLine("Making sound of the Ukulele");
        }
    }

    class Cello : MusicalInstrument
    {
        public Cello(string name) : base(name) { }

        public override void Sound()
        {
            Console.WriteLine("Making sound of the Cello");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
