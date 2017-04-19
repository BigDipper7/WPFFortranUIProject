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
            //FileUtil.editFileContentByRow("test.txt", 2, "哈哈哈");
            string txt11 = this.txtBox11.Text;
            string txt22 = this.txtBox22.Text;
            string txt33 = this.txtBox33.Text;
            string txt12 = this.txtBox12.Text;
            string txt13 = this.txtBox13.Text;
            string txt23 = this.txtBox23.Text;

            string row10 = String.Format("{0} {1} {2} {3} {4} {5}", txt11, txt22, txt33, txt12, txt13, txt23);
            FileUtil.editFileContentByRow("INPUT_simsand.txt", 10, row10);
            MessageBox.Show("succeeded");
            this.Close();
        }
    }
}
