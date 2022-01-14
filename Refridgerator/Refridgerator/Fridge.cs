using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refridgerator
{
    internal class Fridge : IStoreFood, ITryGiveFood, ITryCheckDate
    {
        private List<Food> _food;

        public Fridge()
        {
            _food = new List<Food>();
        }

        public bool TryCheckDate(string name, out DateTime expirationDate)
        {
            Food food = _food.Find(food => food.Name == name);

            if (food == null)
            {
                expirationDate = new DateTime();
                return false;
            }
            expirationDate = food.ExpirationDate;
            return true;
        }

        public void StoreFood(Food food)
        {
            _food.Add(food);
        }

        public bool TryGetFood(string name, out Food food)
        {
            food = _food.Find(food => food.Name == name);

            if (food == null)
            {
                return false;
            }
            _food.Remove(food);
            return true;
        }
    }
}
