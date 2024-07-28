using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 建造者模式.产品类;
using 建造者模式.建造者类_Builder_;
using 建造者模式.指挥者类_Director_;

namespace 建造者模式
{
    internal class Program
    {
        /*
         建造者模式（Builder）
         Builder:为创建一个Product对象的各个部件指定的抽象接口。
         ConcerteBuilder:是具体建造者，实现Builder接口，构造和装配各个部件
         Product:具体的产品角色
         Director:指挥者，构建一个使用Builder接口的对象

         建造模式的使用：主要是创建一些复杂的对象，这些对象内部构建间的顺序通常是稳定的，但对象内部的构建通常面临着复杂的变化
         建造模式的好处:使建造代码与表示代码分离，由于建造者隐藏了该产品是如何组装的，所以若需要改变一个产品的内部表示，只需要再定义一个具体的建造者就好了
         */

        private static void Main(string[] args)
        {
            //客户端不需要知道具体的建造过程
            Director director = new Director();
            Builder builder1 = new ConcerteBuilder1();
            Builder builder2 = new ConcerteBuilder2();

            director.Construct(builder1);
            Product p1 = builder1.GetResult();
            p1.Show();
            director.Construct(builder2);
            Product p2 = builder2.GetResult();
            p2.Show();
            Console.Read();
        }
    }
}