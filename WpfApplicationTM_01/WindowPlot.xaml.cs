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

        #region 获取文本某行数据
        ///
        /// 获取文本文件某行数据
        ///
        /// 文本文件路径
        /// 第几行
        /// 返回总行数
        /// 
        private string FileRowText()
        {

            try 
            {
                int i=0;
                using (StreamReader sr = new StreamReader(filePath)) 
                {
                    String line;
                    while ((line = sr.ReadLine()) != null) 
                    {
                        //this.ListBox1.Items.Add("line ");   //增加读出的内容到listbox            
                        i++;

                    }
                    //this.TextBox1.Text=i.ToString(); 显示行数

                }
            }
            catch 
            {
            }
            return "";
        }
        #endregion

        private class OutputStrc
        {
            private int IP;
            private double Eps1;
            private double Eps3;
            private double EpsD;
            private double EpsV;
            private double S1;
            private double S3;
            private double p;
            private double q;
            private double ec;
            private double e;
            private double d;
            private double eta;
            private double wp;
            private double Br;
            private double pm;
        }
    }
}
