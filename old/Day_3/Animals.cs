using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IAnimals
{
    interface IEat
    {
        void eat(string food);
        int eatCount(int count);
    }

    interface ISound
    {
        void meouw ();
        void bark ();
    }
}