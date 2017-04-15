using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.DataSources;

namespace WpfApplicationTM_01
{
    /// <summary>
    /// WindowPlot.xaml 的交互逻辑
    /// </summary>
    public partial class WindowPlot : Window
    {
        private const string filePath = "STRESS-STRAIN.TXT";

        private List<RawPoint> rawPoints = new List<RawPoint>();

        private EnumerableDataSource<RawPoint> rawDS = null;

        public WindowPlot()
        {
            InitializeComponent();

            this.init();
        }

        private void init()
        {
            /*
            rawPoints.Add(new RawPoint(1, 2));
            rawPoints.Add(new RawPoint(2, 2.5));
            rawPoints.Add(new RawPoint(3, 2.7));
            rawPoints.Add(new RawPoint(4, 20));
            rawPoints.Add(new RawPoint(5, 2.9));
            rawPoints.Add(new RawPoint(6, 3));*/

            readFileContent();
            rawDS = new EnumerableDataSource<RawPoint>(rawPoints);


            rawDS.SetXMapping(data=> data.X);
            rawDS.SetYMapping(data=> data.Y);
            
            this.plotter.AddLineGraph(rawDS, Colors.Red, 2, "Test line");
        }

        private void readFileContent()
        {
            FileUtil.FileRowText(filePath, (row) => {
                string[] items = row.Split(new Char[]{' '}, StringSplitOptions.RemoveEmptyEntries);

                OutputStrc resOutput = new OutputStrc();
                resOutput.IP = int.Parse(items[0]);
                resOutput.Eps1 = (double)FileUtil.ChangeDataToD(items[1]);
                resOutput.Eps3 = (double)FileUtil.ChangeDataToD(items[2]);
                rawPoints.Add(new RawPoint(resOutput.Eps1, resOutput.Eps3));
            });
        }

        private class OutputStrc
        {
            public int IP { get; set; }
            public double Eps1 { get; set; }
            public double Eps3 { get; set; }
            public double EpsD { get; set; }
            public double EpsV { get; set; }
            public double S1 { get; set; }
            public double S3 { get; set; }
            public double p { get; set; }
            public double q { get; set; }
            public double ec { get; set; }
            public double e { get; set; }
            public double d { get; set; }
            public double eta { get; set; }
            public double wp { get; set; }
            public double Br { get; set; }
            public double pm { get; set; }
        }

        private class RawPoint
        {
            public double X {get; set;}
            public double Y {get; set;}

            public RawPoint(double x, double y)
            {
                this.X = x;
                this.Y = y;
            }
        }
        

    }
}
