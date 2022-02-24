using System;

namespace lab13 {

    class Program {

        static void Main(string[] args) {

            var burger = new Food("Burger", 50, new Priprava("Cheese"));

            var copy1 = burger.Copy();
            var copy2 = burger.DeepCopy();

            copy2.priprava.name = "222";
            copy2.ToString();
        }
    }
}
