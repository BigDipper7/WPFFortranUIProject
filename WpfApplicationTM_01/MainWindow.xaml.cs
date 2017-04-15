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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace WpfApplicationTM_01
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /**
         * Add invoke method, NO WINDOWS
         * */
        private void invokeFortranProgram()
        {
            const string fileName = "Simsand_fortran.exe";
            Process excProc = new Process();
            excProc.StartInfo.FileName = fileName;
            excProc.StartInfo.CreateNoWindow = true;
            excProc.StartInfo.UseShellExecute = false;
            excProc.Start();
            excProc.WaitForExit();
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            invokeFortranProgram();
        }

        private void btnInitStreState_Click(object sender, RoutedEventArgs e)
        {
            //NavigationWindow window = new NavigationWindow();
            //window.Source = new Uri("WindowInitialStressState.xaml", UriKind.Relative);
            //window.Show();
            WindowInitialStressState winIniStrSta = new WindowInitialStressState();
            //winIniStrSta.Show();
            winIniStrSta.ShowDialog();
        }

        private void btnParams_Click(object sender, RoutedEventArgs e)
        {
            WindowParameters winParams = new WindowParameters();
            winParams.ShowDialog();
        }

        /**
         * open file
         * */
        private void btnImport_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog ofd = new Microsoft.Win32.OpenFileDialog();
            ofd.DefaultExt = ".xls";
            ofd.Filter = "Excel Files(*.xlsx)|*.xlsx|Excel Files 97-2003(*.xls)|*.xls|所有文件(*.*)|*.*";
            ofd.RestoreDirectory = true;
            ofd.ShowDialog();
        }
    }
}
