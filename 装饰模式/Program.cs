using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 装饰模式.ConcerteComponent;
using 装饰模式.ConcreteDecorator_具体服饰类_;

namespace 装饰模式
{
    internal class Program
    {
        /*
         * Component:定义一个对象接口，可以给这些对象动态的添加职责
         * ConcreteComponent:定义一个具体的对象，可以给这个对象添加一些职责
         * Decorator:装饰抽象类，继承了Component,从外类扩展COmponent类的功能，但对Component来说，是无需知道Decorator的存在的
         * ConcerteDecorator:具体的装饰对象，起到给Component添加职责的功能
         */

        private static void Main(string[] args)
        {
            Person person = new Person("小明");
            TShirts shirts = new TShirts();
            BigTrouser bigTrouser = new BigTrouser();
            Tie tie = new Tie();
            shirts.Decorate(person);       //装饰过程
            bigTrouser.Decorate(shirts);
            tie.Decorate(bigTrouser);
            tie.Show();
            Console.Read();
        }
    }
}