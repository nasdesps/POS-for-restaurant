using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    
    public partial class Chart : Form
    {
        Dictionary<string, int> sales = new Dictionary<string, int>();
        public Chart(Dictionary<string, int> salesChart)
        {
            InitializeComponent();
            this.sales = salesChart;
            chart();
        }

        private void chart()
        {
            int count = 0;
            foreach (KeyValuePair<string, int> item in sales)
            {
                salesChart.Series["Sales Chart"].Points.Add(item.Value);
                salesChart.Series["Sales Chart"].Points[count].LegendText = item.Key;
                salesChart.Series["Sales Chart"].Points[count].Label = Convert.ToString(item.Value);
                count++;
            }
            sales.Clear();
        }
        
    }
}
