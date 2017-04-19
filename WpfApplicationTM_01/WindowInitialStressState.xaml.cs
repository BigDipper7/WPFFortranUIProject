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

namespace WpfApplicationTM_01
{
    /// <summary>
    /// WindowInitialStressState.xaml 的交互逻辑
    /// </summary>
    public partial class WindowInitialStressState : Window
    {
        public WindowInitialStressState()
        {
            InitializeComponent();
        }

        private void btnConcel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
