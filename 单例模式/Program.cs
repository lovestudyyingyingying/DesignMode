using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    internal class Program
    {
        /*
         * 保证一个类只有一个实例。 为什么会有人想要控制一个类所拥有的实例数量？ 最常见的原因是控制某些共享资源 （例如数据库或文件） 的访问权限。
         * 工控领域非常常用，涉及到数据库，或者通信类一般都设计成单例，频繁的实例化会造成资源的损耗
         * 保证使用者无论如何实例化都返回当前存储的类，最常用的设计模式之一
         */

        private static void Main(string[] args)
        {
            //Singleton singleton = new Singleton(); 尝试构造它的时候会报错
            Singleton singleton = Singleton.GetInstance();
            singleton.Name = "test";
            singleton.someBusinessLogic();
            Console.Read();
        }
    }
}