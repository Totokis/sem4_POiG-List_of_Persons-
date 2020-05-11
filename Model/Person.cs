using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Prototype.Model
{

    class Person
    {

        public string Imie { get; private set; }
        public string Nazwisko { get; private set; }
        public uint Wiek { get; private set; }
       
        [JsonConstructor]
        public Person(string imie, string nazwisko, uint wiek)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
            this.Wiek = wiek;
        }

        public Person(string imie, string nazwisko) : this(imie, nazwisko, 15) { }

        public override string ToString()
        {
            return $"{Imie} {Nazwisko}, lat: {Wiek}";
        }

        public bool czy_powtarza(Person p)
        {
            if (p.Imie != this.Imie) return false;
            if (p.Nazwisko != this.Nazwisko) return false;
            if (p.Wiek != this.Wiek) return false;
            return true;
        }
    }
}
