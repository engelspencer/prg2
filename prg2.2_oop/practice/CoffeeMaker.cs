using System;

namespace prg2._2_oop
{
    public class CoffeeMaker
    {
        //this is a method, it is a constructor

        double water_amount;
        double coffee_amount;
        bool on_off;
        bool filter_in;
        //hot plate
        bool grounds_wet;

        double grounds_amount;
        double MAX_GROUNDS_AMOUNT;
        double MAX_COFFEE_AMOUNT;
        double MAX_WATER_AMOUNT;

        public CoffeeMaker()
        {
            water_amount = 0;
            MAX_WATER_AMOUNT = 12;
            coffee_amount = 0;
            MAX_COFFEE_AMOUNT = 12;
            grounds_amount = 0;
            MAX_GROUNDS_AMOUNT = 6;
            on_off = false;
            filter_in = false;
            grounds_wet = false;
        }
        public void AddGrains(double scoops_of_grounds)
        {
            grounds_amount += scoops_of_grounds;
            if(grounds_amount > MAX_GROUNDS_AMOUNT)
            {
                //Console.WriteLine("Put some of that back, that's too much!");
                //grounds_amount = MAX_GROUNDS_AMOUNT;
                throw new Exception("Put some of that back, that's too much!");
            }
        }
        public void InsertFilter()
        {
            filter_in = true;
        }
        public void AddWater(double cups_of_water)
        {
            water_amount += cups_of_water;
            if(water_amount > MAX_WATER_AMOUNT)
            {
                Console.WriteLine("Put some of that back, that's too much!");
                water_amount = MAX_WATER_AMOUNT;
            }
        }
        public void TurnOn()
        {
            on_off = true;
            MakeCoffee();
        }
        public void MakeCoffee()
        {
            coffee_amount = water_amount;
            water_amount = 0;
            grounds_wet = true;
        }
        public void TurnOff()
        {
            on_off = false;
        }
    }
}