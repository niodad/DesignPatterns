using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton _singleton ;
        public Singleton  GetSingleTon()
        {
            if (_singleton ==null)
            {
                _singleton = new Singleton();

            }
            return _singleton;
        }
    }
}
