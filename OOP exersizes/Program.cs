using System;

namespace OOP_exersizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Character KungFuPanda = new Character("Kung Fu Panda", "Skadoosh", "You have been blinded by pure awesomeness!");
            Character SpiderMan = new Character("Spider Man", "My spider sense is tingling", "your friendly neighboruhood spiderman");

            KungFuPanda.speak(1);
            KungFuPanda.setLevel(2);
            KungFuPanda.speak(2);


        }
    }
}
