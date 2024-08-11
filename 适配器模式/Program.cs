using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 适配器模式.Adepter;
using 适配器模式.Target;

namespace 适配器模式
{
    internal class Program
    {
        //系统的数据和行为都正确，但接口不符时，我们应该考虑使用适配器，目的是使控制范围外的一个原有对象与某个接口匹配。适配器模式主要应用于希望复用一些现存的类，但是接口又与复用环境要求不一致的情况
        //下面的例子举了姚明去nba的场景，他需要一个翻译帮助翻译它的行为
        private static void Main(string[] args)
        {
            Player player = new Forwards("巴蒂尔");
            player.Attack();

            Player m = new Guards("麦克格雷迪");
            m.Attack();

            Player ym = new Translator("姚明");
            ym.Attack();
            ym.Defense();
            Console.Read();
        }
    }
}