
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp17
{
    public delegate void Taxation(Person person);
    public class Person
    {
        int priceStock = 1000;
        private Taxation handler;

        public void RegisterHandler(Taxation handler)
        {
            this.handler = handler;
        }
        public void UnRegisterHandler(Taxation handler)
        {
            this.handler = null;
        }
        public string Name { get; set; }
        public string SurName { get; set; }
        private int cash=100000;
        private int stocks = 100;
        public void Buy(Person person, int count)
        {
            cash -= count * priceStock;
            stocks += count;
            person.stocks -= count;
            person.cash += count * priceStock;
            handler.Invoke(this);
        }
        public void Sell(Person person,int count)
        {
            cash += count * priceStock;
            stocks -= count;
            person.stocks += count;
            person.cash -= count * priceStock;
            handler.Invoke(this);
        }

    }
}