using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 装饰模式.Decorator;

namespace 装饰模式.ConcreteDecorator_具体服饰类_
{
    internal class TShirts : Finery
    {
        public override void Show()
        {
            Console.Write("big Tshirts");
            base.Show();
        }
    }

    internal class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.Write("垮裤");
            base.Show();
        }
    }

    internal class Tie : Finery
    {
        public override void Show()
        {
            Console.Write("领带");
            base.Show();
        }
    }
}