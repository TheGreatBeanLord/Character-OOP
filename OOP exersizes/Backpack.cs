using System;
using System.Collections.Generic;
using System.Text;


namespace OOP_exersizes
{
    class Backpack
    {
        //Feilds
        private string size;

        private List<object> items = new List<object>();

        //Constructors
        public Backpack(string initColor, string initSize, List<object> initItems, bool initIsOpen)
        {
            Color = initColor;
            Size = initSize;
            IsOpen = initIsOpen;

            if (initItems != null)
            {
                Items = initItems;
            }

        }

        //Properties

        public string Color {
            get; set;
         }
        
        public string Size
        {
            get
            {
                return size;
            }
            set
            {
                if (value == "small" || value == "medium" || value == "large")
                {
                    size = value;
                }
            }
        }

        public bool IsOpen
        {
            get; set;
        } = false;

        public List<object> Items
        {
            get
            {
                return items;
            }

            set
            {
                if (value != null)
                {
                    items = value;
                }

            }
        }


        //Methods

        public void openBag()
        {
            IsOpen = true;
            Console.WriteLine("Bag is open!");
        }

        public void closeBag()
        {
            IsOpen = false;
            Console.WriteLine("Bag is closed!");
        }

        public void putIn(object item)
        {
            if (this.IsOpen)
            {
                Items.Add(item);
                Console.WriteLine("Putting in " + item);
            }
            else
            {
                Console.WriteLine("you need to open the backpack to put stuff in!");
            }
        }

        public void takeOut(object item)
        {
            if (this.IsOpen)
            {
                bool wasfound = false;
                for (int i = 0; i < Items.Count; i++)
                {
                    if (item == Items[i])
                    {
                        Console.WriteLine("taking out " + item);
                        Items.RemoveAt(i);
                        wasfound = true;
                        i = Items.Count;
                    }
                }

                if (!wasfound)
                {
                    Console.WriteLine("couldnt find " + item);
                }
            }
            else
            {
                Console.WriteLine("you need to open the backpack to take stuff out!");
            }
        }

    }
}
