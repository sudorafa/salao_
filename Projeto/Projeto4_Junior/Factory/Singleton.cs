using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Factory
{
    class Singleton
    {
        private static Singleton instance;

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        } 
    }
}
