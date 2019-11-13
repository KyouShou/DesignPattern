using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SingletonPattern
{
    public class Singleton
    {
        public string Name { get; set; }
        private static Singleton _instance;

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }

                return _instance;
            }
        }

        private Singleton()
        {
            //建構子用private層級，使其無法初始化
        }

    }
}
