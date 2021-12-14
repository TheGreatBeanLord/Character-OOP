using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_exersizes
{
    class Character
    {
        //Feilds
        public List<string> phrases = new List<string>();
        public string name;

        //Properties

        int Level
        {
            get;
            set;
        } = 0;



        //Constructors
        public Character(string initName, string initPhrase1, string initPhrase2)
        {
            phrases.Add(initPhrase1);
            phrases.Add(initPhrase2);
            name = initName;
        }
        //Methods

        public void speak(int phraseNum)
        {
            Console.WriteLine(phrases[phraseNum - 1]);
        }

        public void setLevel(int newLevel)
        {
            Level = newLevel;
            Console.WriteLine("name is now level " + Level);
        }

    }
}
