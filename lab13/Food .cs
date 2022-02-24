using System;
using System.Collections.Generic;
using System.Text;

namespace lab13 {

    class Food : IClonable {

        public Priprava priprava;
        public string name;
        public int healPerUse;

        public Food(string Name,int HealPerUse, Priprava Priprava) {
            name = Name;
            healPerUse = HealPerUse;
            priprava = Priprava;
        }

        public Food Copy() {
            return (Food)MemberwiseClone();
        }

        public Food DeepCopy() {
            Food food = Copy();
            food.priprava = new Priprava(priprava.name);
            return food;
        }    
    }

}
