using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WpfApplicationTM_01
{
    class FileUtil
    {
        public static Decimal ChangeDataToD(string strData)
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
        public static List<string> FileRowText(string filePath, CallbackHandler callback)
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

    }
}
