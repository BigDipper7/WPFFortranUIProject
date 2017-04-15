using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WpfApplicationTM_01
{
    class FileUtil
    {
        public Decimal ChangeDataToD(string strData)
        {
            Decimal dData = 0.0M;
            if (strData.Contains("E"))
            {
                dData = Convert.ToDecimal(Decimal.Parse(strData.ToString(), System.Globalization.NumberStyles.Float));
            }
            return dData;
        }


        public delegate void CallbackHandler(String str);

        #region 获取文本某行数据
        ///
        /// 获取文本文件某行数据
        ///
        /// 文本文件路径
        /// 第几行
        /// 返回总行数
        /// 
        public List<string> FileRowText(string filePath, CallbackHandler callback)
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
                        callback(line);
                        //this.ListBox1.Items.Add("line ");   //增加读出的内容到listbox            
                        i++;

                        if (i == 1)
                        {
                            continue;
                        }

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
            private int IP {get; set;}
            private double Eps1 { get; set; }
            private double Eps3 { get; set; }
            private double EpsD { get; set; }
            private double EpsV { get; set; }
            private double S1 { get; set; }
            private double S3 { get; set; }
            private double p { get; set; }
            private double q { get; set; }
            private double ec { get; set; }
            private double e { get; set; }
            private double d { get; set; }
            private double eta { get; set; }
            private double wp { get; set; }
            private double Br { get; set; }
            private double pm { get; set; }
        }
    }
}
