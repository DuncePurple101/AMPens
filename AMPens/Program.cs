using System;

namespace AMPens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Pen CaseysAmericanPen = new Pen(); //Instantiated a Pen!
            CaseysAmericanPen.Name = "Casey's Pen from America in 2004";
            CaseysAmericanPen.InkColor = "Red";
            CaseysAmericanPen.HasCap = true;
            CaseysAmericanPen.InkLevelPercent = 0.0f;
            CaseysAmericanPen.NumberOfInkColors = 1;
            CaseysAmericanPen.CasingThickness = 0.25f;
            CaseysAmericanPen.HasLight = true;
            CaseysAmericanPen.IsUsable = true;

            //Console.WriteLine(CaseysAmericanPen.Name + " has " + CaseysAmericanPen + " ink. ");

            Pen Bic4C = new Pen("The Bic 4 Color Geek Pen", 0.4f, "Multiple", false, 4, 100);
            //Console.WriteLine(Bic4C.Name + " has " + Bic4C.InkColor + " ink. ");


            CaseysAmericanPen.Describe();
            Bic4C.Describe();


        }
    }
}
