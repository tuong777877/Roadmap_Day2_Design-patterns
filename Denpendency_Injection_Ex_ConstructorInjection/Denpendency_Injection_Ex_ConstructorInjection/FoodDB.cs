using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Denpendency_Injection_Ex_ConstructorInjection
{
    public interface IFoodDB
    {
        List<Food> SelectAllFoods();
    }
    public class FoodDB : IFoodDB
    {
        public List<Food> SelectAllFoods()
        {
            List<Food> foodDB = new List<Food>();
            foodDB.Add(new Food() { FoodId = 1, FoodName = "Coca Cola", FoodPrice = 1.25 });
            foodDB.Add(new Food() { FoodId = 2, FoodName = "Pizza", FoodPrice = 12.3 });
            foodDB.Add(new Food() { FoodId = 1, FoodName = "Noddle", FoodPrice = 3.25 });
            return foodDB;
        }
    }
}
