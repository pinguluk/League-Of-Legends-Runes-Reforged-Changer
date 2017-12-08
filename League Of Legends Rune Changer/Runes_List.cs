using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_Of_Legends_Rune_Changer {

    class Runes_List {
        public string Name { get; set; }
        public string Url { get; set; }
        public int Number { get; set; }

        public Runes_List(string name, string url) {
            Name = name;
            Url = url;
        }

        public override string ToString() {
            return Name; 
        }
    }

}
