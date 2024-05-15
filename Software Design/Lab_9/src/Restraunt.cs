using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9.src
{
    public class Restraunt
    {
        public List<Worker> reception;
        public List<Worker> waiters;
        public List<Worker> cooks;

        private List<string> menu;

        public Restraunt()
        {
            reception = new();
            reception.Add(new Worker(true));

            waiters = new();
            waiters.Add(new Worker(true));
            waiters.Add(new Worker(false));

            cooks = new();
            cooks.Add(new Worker(false));
            cooks.Add(new Worker(false));
            cooks.Add(new Worker(false));

            menu = new() 
            {
                "Стейк",
                "Риба",
                "Паста"
            };
        }

        public void GetOrder(string food)
        {
            bool isRestrauntAvailible = false;

            foreach (Worker worker in reception)
            {
                if (worker.isAvailible)
                {
                    isRestrauntAvailible = true;
                    break;
                }
            }

            if (!isRestrauntAvailible)
            {
                Console.WriteLine("Ресторан не може поки приймати замовлення");
                return;
            }


            if (menu.Contains(food))
            {
                Console.WriteLine("Замовлення було прийнято");
                CookFood(food);
            }
            else
            {
                Console.WriteLine("Такої страви немає у меню ресторану");
            }
        }

        private void CookFood(string food)
        {
            bool isKitchenAvailible = false;

            foreach (Worker worker in cooks)
            {
                if (worker.isAvailible)
                {
                    isKitchenAvailible = true;
                    break;
                }
            }

            if (!isKitchenAvailible)
            {
                Console.WriteLine("Кухня поки недоступна, тому їжа не може бути приготована");
                return;
            }

            Console.WriteLine($"Кухарі приготували {food}");

            ServeFood(food);
        }

        private void ServeFood(string food)
        {
            bool areWaitersAvailible = false;

            foreach (Worker worker in cooks)
            {
                if (worker.isAvailible)
                {
                    areWaitersAvailible = true;
                    break;
                }
            }

            if (!areWaitersAvailible)
            {
                Console.WriteLine("Офіціанти поки зайняті. Доведеться почекати");
                return;
            }

            Console.WriteLine($"{food} було подано клієнту");
        }
    }
}
