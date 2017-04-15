using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WpfApplicationTM_01
{
    class FileUtil
    {
        private Decimal ChangeDataToD(string strData)
        {
            Decimal dData = 0.0M;
            if (strData.Contains("E"))
            {
                dData = Convert.ToDecimal(Decimal.Parse(strData.ToString(), System.Globalization.NumberStyles.Float));
            }
            return dData;
        }



        #region 获取文本某行数据
        ///
        /// 获取文本文件某行数据
        ///
        /// 文本文件路径
        /// 第几行
        /// 返回总行数
        /// 
        private List<string> FileRowText(string filePath)
        {
            List<string> result = new List<string>();

            try
            {
                int i = 0;
                using (StreamReader sr = new StreamReader(filePath))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        //this.ListBox1.Items.Add("line ");   //增加读出的内容到listbox            
                        i++;
                        result.Add(line);
                    }
                    //this.TextBox1.Text=i.ToString(); 显示行数

                }
            }
            catch
            {
            }
            return result;
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
