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

        private RawDataSource rawDS = new RawDataSource();

        public WindowPlot()
        {
            InitializeComponent();

            this.init();
        }

        private void init()
        {
            this.plotter.AddLineGraph(rawDS, Colors.Red, 2, "Test line");
        }

        private void readFileContent()
        {
            
        }

        #region 获取文本某行数据
        ///
        /// 获取文本文件某行数据
        ///
        /// 文本文件路径
        /// 第几行
        /// 返回总行数
        /// 
        private string FileRowText(string filePath, ref int j)
        {

            try 
            {
                int i=0;
                using (StreamReader sr = new StreamReader("TestFile.txt")) 
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
    }
}
