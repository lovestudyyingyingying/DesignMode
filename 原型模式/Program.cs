using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 原型模式.实例类;

namespace 原型模式
{
    internal class Program
    {   /*
         * 原型模式就是从一个对象再创建另外一个可定制的对象，而不需要知道任何创建的细节
         * 其实就是实现C#的ICloneable接口，注意深拷贝和浅拷贝的区别，浅拷贝当包含对象字段或属性时拷贝的是它的引用
         */

        private static void Main(string[] args)
        {
            //浅拷贝时
            //首先创建一个类
            Person personOne = new Person();
            personOne.IdInfo = new IdInfo(666);
            Console.WriteLine($"before shallow copy the id is {personOne.IdInfo.IdNumber}");
            Person personTwo = personOne.ShallowCopy();//浅拷贝
            //此时修改idInfo,同时第一个也会被修改
            personTwo.IdInfo.IdNumber = 1;
            Console.WriteLine($"after copy and change two's id ,so two's id is {personTwo.IdInfo.IdNumber},at the same time, one's id is {personOne.IdInfo.IdNumber},we can see bother had been change");

            Console.WriteLine("------------------------------------------------------------");
            Person personThree = personOne.DeepCopy();
            personThree.IdInfo.IdNumber = 888;
            Console.WriteLine($"after copy and change three's id ,so three's id is {personThree.IdInfo.IdNumber},at the same time, one's id is {personOne.IdInfo.IdNumber},we can see  had not been change");
            Console.Read();
        }
    }
}