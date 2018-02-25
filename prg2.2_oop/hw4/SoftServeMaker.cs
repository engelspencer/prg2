using System.Collections.Generic;
using System;

namespace prg2._2_oop
{
    public class SoftServeMaker : ConsumableMaker
    {
        //Constructor adds a dictionary of ingredients
        //Requires a double for the maximum amount of ice cream it can produce
        public SoftServeMaker(double MaxYield)
        {
            //List of Ingredients
            Ingredients = new Dictionary<Type, Consumable>();
            Ingredients [typeof(WholeMilk)] = new WholeMilk();
            Ingredients [typeof(Sugar)] = new Sugar();
            Ingredients [typeof(Cream)] = new Cream();
            Ingredients [typeof(MilkPowder)] = new MilkPowder();
            Ingredients [typeof(VanillaExtract)] = new VanillaExtract();
            Ingredients [typeof(Salt)] = new Salt();
            Ingredients [typeof(DryIce)] = new DryIce();

            //Maximum quantities based on ratios of a certain ingredient to the yield of the machine, calculated using the desired maximum output
            MaxIngredients = new Dictionary<Type, double>();
            MaxIngredients [typeof(WholeMilk)] = 0.606 * MaxYield;
            MaxIngredients [typeof(Sugar)] = 0.138 * MaxYield;
            MaxIngredients [typeof(Cream)] = 0.062 * MaxYield;
            MaxIngredients [typeof(MilkPowder)] = 0.059 * MaxYield;
            MaxIngredients [typeof(VanillaExtract)] = 0.007 * MaxYield;
            MaxIngredients [typeof(Salt)] = 0.002 * MaxYield;
            MaxIngredients [typeof(DryIce)] = 0.548 * MaxYield;
        }
        //Methods to add ingredients
        //If the entered amount increases the total to greater than the max, throw exception
        public void AddWholeMilk(double amount)
        {
            if(Ingredients [typeof(WholeMilk)].quantity + amount <= MaxIngredients [typeof(WholeMilk)])
            {
                Ingredients [typeof(WholeMilk)].quantity += amount;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public void AddSugar(double amount)
        {
            if(Ingredients [typeof(Sugar)].quantity + amount <= MaxIngredients [typeof(Sugar)])
            {
                Ingredients [typeof(Sugar)].quantity += amount;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public void AddCream(double amount)
        {
            if(Ingredients [typeof(Cream)].quantity + amount <= MaxIngredients [typeof(Cream)])
            {
                Ingredients [typeof(Cream)].quantity += amount;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public void AddMilkPowder(double amount)
        {
            if(Ingredients [typeof(MilkPowder)].quantity + amount <= MaxIngredients [typeof(MilkPowder)])
            {
                Ingredients [typeof(MilkPowder)].quantity += amount;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public void AddVanillaExtract(double amount)
        {
            if(Ingredients [typeof(VanillaExtract)].quantity + amount <= MaxIngredients [typeof(VanillaExtract)])
            {
                Ingredients [typeof(VanillaExtract)].quantity += amount;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public void AddSalt(double amount)
        {
            if(Ingredients [typeof(Salt)].quantity + amount <= MaxIngredients [typeof(Salt)])
            {
                Ingredients [typeof(Salt)].quantity += amount;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        public void AddDryIce(double amount)
        {
            if(Ingredients [typeof(DryIce)].quantity + amount <= MaxIngredients [typeof(DryIce)])
            {
                Ingredients [typeof(DryIce)].quantity += amount;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
        //Make method
        //icecream.quantity is based on the percent yield from the total ingredients used
        public override Consumable Make()
        {
            SoftServe icecream = new SoftServe();
            icecream.quantity = 0.703 * (Ingredients[typeof(WholeMilk)].quantity + Ingredients[typeof(Sugar)].quantity + Ingredients[typeof(Cream)].quantity + Ingredients[typeof(MilkPowder)].quantity + Ingredients[typeof(VanillaExtract)].quantity + Ingredients[typeof(Salt)].quantity + Ingredients[typeof(DryIce)].quantity);
            return icecream;
        }
    }
}