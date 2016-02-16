using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 开闭原则.Abstract;
using 开闭原则.Business;
using 开闭原则.Module;

namespace 开闭原则
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractChart chart = new PieChart();
            ChartDisplay chartDisplay = new ChartDisplay();

            chartDisplay.SetChart(chart);
            chartDisplay.Display();

           // Console.ReadLine();
        }
    }
}
