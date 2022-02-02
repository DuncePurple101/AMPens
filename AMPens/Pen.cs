using System;
using System.Collections.Generic;
using System.Text;

namespace AMPens
{
    public class Pen
    {

        //Properties
        public string Name;
        public float CasingThickness;
        public string InkColor;
        public bool HasCap;
        public int NumberOfInkColors;
        public float InkLevelPercent;
        public bool HasLight;
        public bool IsUsable;

        //Constructors
        public Pen()
        {

        }

        public Pen(string name, float casingThickness, string inkColor, bool hasCap, int numberOfInkColors, float inkLevelPercent)
        {
            Name = name;
            CasingThickness = casingThickness;
            InkColor = inkColor;
            HasCap = hasCap;
            NumberOfInkColors = numberOfInkColors;
            InkLevelPercent = inkLevelPercent;
        }

        public Pen(bool hasLight, bool isUsable)
        {
            HasLight = hasLight;
            IsUsable = isUsable;
        }



        //Methods
        public void Describe()
        {
            Console.WriteLine("\tIs Usable: " + IsUsable);
            if(IsUsable = true)
            {
                Console.WriteLine("Please don't break me");
            }
            Console.WriteLine("\tHas Light: " + HasLight);
            Console.WriteLine("\nInformation about " + Name);
            Console.WriteLine("\tInk Color: " + InkColor);
            Console.WriteLine("\tHas Cap?: " + HasCap);
            Console.WriteLine("\tInk Level%: " + InkLevelPercent);
            if(InkLevelPercent < 10)
            {
                Console.WriteLine("Needs A Refill!!");
            }
        }


    }
}
