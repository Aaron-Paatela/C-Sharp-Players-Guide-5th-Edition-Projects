// Written By Aaron Paatela
// 2/15/2025
// This is the separate class for the Homework 3 Simula's Soup exercise
// in C# Player's Guide 5th edition on page 143


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simula_s_Soup_Attempt_2__page_143_
{
    public class SimulasSoupClass
    {

        // Soup enums
        public enum Type
        {
            Soup,
            Stew,
            Gumbo
        }
        public enum Ingredient
        {
            Mushrooms,
            Chicken,
            Carrots,
            Potatoes
        }
        public enum Seasoning
        {
            Spicy,
            Salty,
            Sweet
        }

        // methods

        public static (Type, Ingredient, Seasoning) MakeASoup(string stringType, string stringIngredient, string stringSeasoning)
        {
            (Type, Ingredient, Seasoning) returnSoup = (Type.Stew, Ingredient.Potatoes, Seasoning.Spicy);
            if (stringType == "soup")
            {
                returnSoup.Item1 = Type.Soup;
            }
            else if (stringType == "stew")
            {
                returnSoup.Item1 = Type.Stew;
            }
            else if (stringType == "gumbo")
            {
                returnSoup.Item1 = Type.Gumbo;
            }
            if (stringIngredient == "mushrooms")
            {
                returnSoup.Item2 = Ingredient.Mushrooms;
            }
            else if (stringIngredient == "chicken")
            {
                returnSoup.Item2 = Ingredient.Chicken;
            }
            else if (stringIngredient == "carrots")
            {
                returnSoup.Item2 = Ingredient.Carrots;
            }
            else if (stringIngredient == "potatoes")
            {
                returnSoup.Item2 = Ingredient.Potatoes;
            }
            if (stringSeasoning == "spicy")
            {
                returnSoup.Item3 = Seasoning.Spicy;
            }
            else if (stringSeasoning == "salty")
            {
                returnSoup.Item3 = Seasoning.Salty;
            }
            else if (stringSeasoning == "sweet")
            {
                returnSoup.Item3 = Seasoning.Sweet;
            }
            return returnSoup;
        }


    }
}
