using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPEN_AQ_Pollution
{
    public partial class ChartCountry : UserControl
    {
        public ChartCountry()
        {
            InitializeComponent();
        }
        public void Init(string country,string[] cites, List<Pollution> pollutions)
        {
            tabControl1.TabPages.Clear();
            foreach (var item in cites)
            {
                tabControl1.TabPages.Add(item);
                tabControl1.TabPages[tabControl1.TabCount - 1].BackColor = Color.Black;
                var pollutionsCity = pollutions.Where(p => p.City == item).ToList();
                var chart = new ChartPollution(pollutionsCity);
                chart.Dock = DockStyle.Fill;
                tabControl1.TabPages[tabControl1.TabCount - 1].Controls.Add(chart);
            }
        }
    }
}
