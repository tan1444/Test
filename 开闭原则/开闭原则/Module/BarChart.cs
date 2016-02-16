using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 开闭原则.Abstract;

namespace 开闭原则.Module
{
    public class BarChart : AbstractChart
    {
        public override void Display()
        {
            Console.WriteLine("柱状图");
        }
    }
}
