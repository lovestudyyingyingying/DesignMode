using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 建造者模式.产品类;

namespace 建造者模式.建造者类_Builder_
{
    internal abstract class Builder
    {
        public abstract void BuildPartA();

        public abstract void BuildPartB();

        public abstract Product GetResult();
    }
}