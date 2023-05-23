using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Симулятор_программиста
{
    class Job
    {
        public int income { get; private set; }
        public int needexp { get; private set; }

        public Job(int haveexp)
        {
            Random random = new Random();
            needexp = random.Next(haveexp - 30, haveexp + 1);
            if (needexp < 0) needexp = 0;
            income = needexp * random.Next(800, 1200);
            if (income < 15000) income = random.Next(15000, 25000);
        }
    }
}
