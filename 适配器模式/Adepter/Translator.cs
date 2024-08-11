using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 适配器模式.Adeptee;
using 适配器模式.Target;

namespace 适配器模式.Adepter
{
    internal class Translator : Player
    {
        private ForeignCenter foreignCenter = new ForeignCenter();

        public Translator(string name) : base(name)
        {
            foreignCenter.Name = name;
        }

        public override void Attack()
        {
            foreignCenter.进攻();
        }

        public override void Defense()
        {
            foreignCenter.防守();
        }
    }
}