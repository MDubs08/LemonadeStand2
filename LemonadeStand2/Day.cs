using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand2
{
    public class Day
    {
        public Weather weather = new Weather();
        public List<Customer> customer = new List<Customer>();
        static Random randomCustomer = new Random();
        public int dayNumber;
        public int totalCustomers;
        public int maxCustomers = 100;
        public int minCustomers = 50;
        public Day()
        {
            totalCustomers = 70;
        }
        public void GetNumberOfCustomers()
        {
            totalCustomers = randomCustomer.Next(minCustomers, maxCustomers);
        }
        public void PopulateCustomers()
        {
            for (int i = 0; i < totalCustomers; i++)
            {
                customer.Add(new Customer());
            }
        }
        public void SetWeatherEffect()
        {
            for (int i = 0; i < totalCustomers; i++)
            {
                customer[i].SetWeatherEffect();
            }
        }
        public void SetForecast()
        {

        }
    }
}
