using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式.产品类
{
    internal class Product
    {
        internal string partA;//部位可能是抽象类

        internal string partB;

        public void Add(string partA, string partB)
        {
            this.partA = partA;
            this.partB = partB;
        }

        public void Show()
        {
            Console.WriteLine("\n房子 创建---");

            Console.WriteLine(partA);
            Console.WriteLine(partB);
        }
    }
}