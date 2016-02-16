using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 开闭原则.Abstract;

namespace 开闭原则.Business
{
    public class ChartDisplay
    {
        private AbstractChart _chart;

        public void SetChart(AbstractChart chart)
        {
            if (chart == null) throw new ArgumentNullException("chart");
            _chart = chart;
        }

        public void Display()
        {
            _chart.Display();
        }
    }
}
