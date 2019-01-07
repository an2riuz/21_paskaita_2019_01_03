﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_paskaita_2019_01_03
{
    class Singleton
    {
        private static Singleton _instance;
        private Singleton()
        {

        }

        public static Singleton Instance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
