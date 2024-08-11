using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 适配器模式.Target
{
    internal abstract class Player
    {
        protected string name;

        public Player(string name)
        {
            this.name = name;
        }

        public abstract void Attack();

        public abstract void Defense();
    }

    internal class Forwards : Player
    {
        public Forwards(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine($"前锋{name}进攻");
        }

        public override void Defense()
        {
            Console.WriteLine($"前锋{name}防守");
        }
    }

    internal class Center : Player
    {
        public Center(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine($"中锋{name}进攻");
        }

        public override void Defense()
        {
            Console.WriteLine($"中锋{name}防守");
        }
    }

    internal class Guards : Player
    {
        public Guards(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine($"后卫{name}进攻");
        }

        public override void Defense()
        {
            Console.WriteLine($"后卫{name}防守");
        }
    }
}