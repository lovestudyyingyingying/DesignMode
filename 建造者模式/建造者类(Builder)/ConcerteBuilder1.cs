using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 建造者模式.产品类;

namespace 建造者模式.建造者类_Builder_
{
    internal class ConcerteBuilder1 : Builder
    {
        private Product product = new Product();

        public override void BuildPartA()
        {
            product.partA = "木门";
        }

        public override void BuildPartB()
        {
            product.partB = "水泥墙";
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}