using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPEN_AQ_Pollution
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }



        private DataBase.DatabaseContext _pollutionContext;

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCity_Click(object sender, EventArgs e)
        {
            line.Top = (sender as Bunifu.Framework.UI.BunifuFlatButton).Top;
            panelCity.BringToFront();
        }

        private void buttonCountry_Click(object sender, EventArgs e)
        {
            line.Top = (sender as Bunifu.Framework.UI.BunifuFlatButton).Top;
            panelCountry.BringToFront();
        }

        private void buttonPollution_Click(object sender, EventArgs e)
        {
            line.Top = (sender as Bunifu.Framework.UI.BunifuFlatButton).Top;
            panelPollution.BringToFront();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(this.Width.ToString());
            _pollutionContext = new DataBase.DatabaseContext();
            Observer.ObserverPollution observerPollution = new Observer.ObserverPollution();
            observerPollution.Start();
            comboBoxCity.Items.AddRange(_pollutionContext.Pollutions.Select(x => x.City).Distinct().ToArray());
            comboBoxPollution.Items.AddRange(_pollutionContext.Pollutions.Select(x => x.Parameter).Distinct().ToArray());
            comboBoxCountry.Items.AddRange(_pollutionContext.Pollutions.Select(x => x.Country).Distinct().ToArray());
            comboBoxCountryPollution.Items.AddRange(_pollutionContext.Pollutions.Select(x => x.Parameter).Distinct().ToArray());
            comboBoxPollutionCities.Items.AddRange(_pollutionContext.Pollutions.Select(x => x.City).Distinct().ToArray());

            comboBoxCity.SelectedIndex = comboBoxCity.Items.Count > 0 ? 0 : -1;
            comboBoxPollution.SelectedIndex = comboBoxPollution.Items.Count > 0 ? 0 : -1;
            comboBoxCountry.SelectedIndex = comboBoxCountry.Items.Count > 0 ? 0 : -1;
            comboBoxCountryPollution.SelectedIndex = comboBoxCountryPollution.Items.Count > 0 ? 0 : -1;
            comboBoxPollutionCities.SelectedIndex = comboBoxPollutionCities.Items.Count > 0 ? 0 : -1;

            comboBoxPeriod.SelectedIndex = comboBoxPeriod.Items.Count > 0 ? 0 : -1;
            comboBoxPollutionPeriod.SelectedIndex = comboBoxPollutionPeriod.Items.Count > 0 ? 0 : -1;
            comboBoxCountryPeriod.SelectedIndex = comboBoxPeriod.Items.Count > 0 ? 0 : -1;

            comboBoxCity_SelectedIndexChanged(null, null);
            comboBoxCountry_SelectedIndexChanged(null, null);
            comboBoxPollutionCities_SelectedIndexChanged(null, null);
        }


        private void FindPollution()
        {
            if (comboBoxCity.SelectedIndex < 0 || comboBoxPollution.SelectedIndex < 0 || comboBoxPeriod.SelectedIndex < 0) return;
            DateTime date = DateTime.Now;
            switch (comboBoxPeriod.SelectedIndex)
            {
                case 0:
                    date = DateTime.Now.AddDays(-1);
                    break;
                case 1:
                    date = DateTime.Now.AddDays(-7);
                    break;
                case 2:
                    date = DateTime.Now.AddDays(-30);
                    break;
                default:
                    break;
            }
            chartPollution1.Init(_pollutionContext.Pollutions.
                Where(x => x.City == comboBoxCity.SelectedItem.ToString() &&
                x.Parameter == comboBoxPollution.SelectedItem.ToString() &&
                x.LastUpdate >= date).ToList());
            
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindPollution();

        }

        private void ChartLegend_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MessageBox.Show("123");
        }

        private void panelCountry_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCountry.SelectedIndex < 0 || comboBoxCountryPollution.SelectedIndex < 0 || comboBoxCountryPeriod.SelectedIndex < 0) return;

            DateTime date = DateTime.Now;
            switch (comboBoxCountryPeriod.SelectedIndex)
            {
                case 0:
                    date = DateTime.Now.AddDays(-1);
                    break;
                case 1:
                    date = DateTime.Now.AddDays(-7);
                    break;
                case 2:
                    date = DateTime.Now.AddDays(-30);
                    break;
                default:
                    break;
            }
            var pollutions=_pollutionContext.Pollutions.Where(p => p.Country == comboBoxCountry.SelectedItem.ToString() &&
                                                  p.Parameter == comboBoxCountryPollution.SelectedItem.ToString() &&
                                                  p.LastUpdate >= date).ToList();
            chartCountry1.Init(comboBoxCountry.SelectedItem.ToString(), pollutions.Select(p => p.City).Distinct().ToArray(), pollutions);
        }

        private void comboBoxPollutionCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPollutionCities.SelectedIndex < 0 || comboBoxPollutionPeriod.SelectedIndex < 0) return;

            DateTime date = DateTime.Now;
            switch (comboBoxCountryPeriod.SelectedIndex)
            {
                case 0:
                    date = DateTime.Now.AddDays(-1);
                    break;
                case 1:
                    date = DateTime.Now.AddDays(-7);
                    break;
                case 2:
                    date = DateTime.Now.AddDays(-30);
                    break;
                default:
                    break;
            }
            var pollutions = _pollutionContext.Pollutions.Where(p => p.City == comboBoxPollutionCities.SelectedItem.ToString() &&
                                                                   p.LastUpdate >= date).ToList();
            chartPollutionCity1.Init(pollutions.Select(p => p.Parameter).Distinct().ToArray(), pollutions);
        }
    }
}
