using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式.Adeptee
{
    //外籍中锋
    internal class ForeignCenter
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void 进攻()
        {
            Console.WriteLine($"外籍中锋{name}进攻");
        }

        public void 防守()
        {
            Console.WriteLine($"外籍中锋{name}防守");
        }
    }
}