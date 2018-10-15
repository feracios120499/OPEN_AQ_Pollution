using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using LiveCharts;

namespace OPEN_AQ_Pollution
{
    public partial class ChartPollution : UserControl
    {
        public ChartPollution()
        {
            InitializeComponent();
            cartesianChart1.ChartLegend = new CustomerLegend();
            (cartesianChart1.ChartLegend as CustomerLegend).ClickLegendText += ChartPollution_ClickLegendText;
        }

  

        public ChartPollution(List<Pollution> pollutions)
        {
            InitializeComponent();
            Init(pollutions);
            cartesianChart1.ChartLegend = new CustomerLegend();
            (cartesianChart1.ChartLegend as CustomerLegend).ClickLegendText += ChartPollution_ClickLegendText;
        }
        private void ChartPollution_ClickLegendText(object sender, EventArgs e)
        {
            foreach(var item in panelLocations.Controls)
            {
                if ((item as MaterialSkin.Controls.MaterialCheckBox).Text == (sender as string))
                    (item as MaterialSkin.Controls.MaterialCheckBox).Checked = !(item as MaterialSkin.Controls.MaterialCheckBox).Checked;
            }
        }
        public class ComparerDate : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                if (Convert.ToDateTime(x) == Convert.ToDateTime(y))
                    return 0;
                if (Convert.ToDateTime(x) < Convert.ToDateTime(y))
                    return -1;
                return 1;
            }
        }
        public void Init(List<Pollution> pollutions)
        {
            //pollutions = new List<Pollution>()
            //{
            //    new Pollution{Location="ALTON",LastUpdate=Convert.ToDateTime("11.10.2018"),Value=0.017},
            //    new Pollution{Location="ALTON",LastUpdate=Convert.ToDateTime("11.10.2018"),Value=0.011},
            //    new Pollution{Location="ALTON",LastUpdate=Convert.ToDateTime("11.10.2018"),Value=0.014},
            //    new Pollution{Location="ALTON",LastUpdate=Convert.ToDateTime("11.10.2018"),Value=0.015},
            //    new Pollution{Location="ALTON",LastUpdate=Convert.ToDateTime("11.10.2018"),Value=0.016},
            //    new Pollution{Location="ALTON",LastUpdate=Convert.ToDateTime("07.11.2016"),Value=0.046},
            //    new Pollution{Location="ALTON",LastUpdate=Convert.ToDateTime("20.07.2017"),Value=0.05},
            //    new Pollution{Location="ALTON",LastUpdate=Convert.ToDateTime("11.10.2018"),Value=0.013},
            //    new Pollution{Location="ALTON",LastUpdate=Convert.ToDateTime("11.10.2018"),Value=0.017},
            //    new Pollution{Location="ALTON",LastUpdate=Convert.ToDateTime("11.10.2018"),Value=0.018}

            //};
            cartesianChart1.Series.Clear();
            panelLocations.Controls.Clear();
            //pollutions = _pollutionContext.Pollutions.Where(p => p.City == "Tucson" && p.Location == "22nd Street & Craycr" && p.Parameter == "o3").ToList();
            var map = Mappers.Xy<DataModel>().X(p => p.Number).Y(p => p.Value);
            var dates = pollutions.Select(p => p.LastUpdate.ToString("dd.MM.yyyy HH:mm:ss")).ToList();
            dates = dates.Distinct().ToList();
            dates.Sort(new ComparerDate());
            foreach (var item in pollutions)
            {
                if (!cartesianChart1.Series.Any(p => p.Title == item.Location))
                {
                    Series series;
                    if (pollutions.FindAll(p => p.Location == item.Location).Count > 1)
                    {
                        series = new LineSeries(map);
                    }
                    else
                    {
                        series = new LineSeries(map) { PointGeometrySize = 19 };
                    }
                    series.Title = item.Location;
                    series.Values = new ChartValues<DataModel>()
                    {
                        new DataModel
                        {
                            Value = item.Value,
                            Number = dates.FindIndex(p => p == item.LastUpdate.ToString("dd.MM.yyyy HH:mm:ss"))
                        }
                    };


                    cartesianChart1.Series.Add(series);
                    var checkBox = new MaterialSkin.Controls.MaterialCheckBox();
                    checkBox.Text = series.Title;
                    checkBox.Checked = true;
                    checkBox.Dock = DockStyle.Top;
                    checkBox.CheckedChanged += CheckBox_CheckedChanged;
                    panelLocations.Controls.Add(checkBox);
                }
                else
                {
                    cartesianChart1.Series.FirstOrDefault(p => p.Title == item.Location).Values.Add(

                         new DataModel { Value = item.Value, Number = dates.FindIndex(p => p == item.LastUpdate.ToString("dd.MM.yyyy HH:mm:ss")) });
                }
            }
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisX.Add(new Axis { Labels = dates });
            cartesianChart1.LegendLocation = LegendLocation.Right;
            if (cartesianChart1.AxisY.Count == 0) cartesianChart1.AxisY.Add(new Axis());
            cartesianChart1.AxisY.FirstOrDefault().LabelFormatter = p => p + " " + pollutions?.FirstOrDefault()?.Unit;
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (sender as CheckBox);
            if (!checkBox.Checked)
            {
                (cartesianChart1.Series.Where(p => p.Title == checkBox.Text).FirstOrDefault() as LineSeries).Visibility = System.Windows.Visibility.Hidden;
            }
            else
            {
                (cartesianChart1.Series.Where(p => p.Title == checkBox.Text).FirstOrDefault() as LineSeries).Visibility = System.Windows.Visibility.Visible;
            }
        }
    }
}
