using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Denpendency_Injection_Ex_PropertyInjection;

namespace Denpendency_Injection_Ex_ConstructorInjection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FoodService foodService = new FoodService(new FoodDB());
            List<Food> listF = foodService.GetAllFoods();
            //FoodList foodlist = new FoodList();
            //List<Food> listF = foodlist.GetAllFoods();
            foreach(var food in listF)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Department = {2}", food.FoodId, food.FoodName, food.FoodPrice);
            }
            Console.ReadKey();
        }
    }
}
