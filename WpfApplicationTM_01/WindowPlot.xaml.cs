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
            rawPoints.Add(new RawPoint(1, 2));
            rawPoints.Add(new RawPoint(2, 2.5));
            rawPoints.Add(new RawPoint(3, 2.7));
            rawPoints.Add(new RawPoint(4, 20));
            rawPoints.Add(new RawPoint(5, 2.9));
            rawPoints.Add(new RawPoint(6, 3));
            rawDS = new EnumerableDataSource<RawPoint>(rawPoints);


            rawDS.SetXMapping(data=> data.X);
            rawDS.SetYMapping(data=> data.Y);
            
            this.plotter.AddLineGraph(rawDS, Colors.Red, 2, "Test line");
        }

        private void readFileContent()
        {
            
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
