using Denpendency_Injection_Ex_ConstructorInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denpendency_Injection_Ex_PropertyInjection
{
    public class FoodService
    {
        private readonly IFoodDB _foodDb;

        public FoodService(IFoodDB foodDb)
        {
            _foodDb = foodDb;
        }
        public List<Food> GetAllFoods()
        {
            return _foodDb.SelectAllFoods();
        }
    }
}
