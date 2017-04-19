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
                        Console.WriteLine(line);
                        //this.ListBox1.Items.Add("line ");   //增加读出的内容到listbox            
                        i++;

                        if (i == 1)
                        {
                            continue;
                        }

                        callback(line);

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


        public delegate void CallbackWriteData(StreamWriter sw);
        public static void exportDataToCSV(string fileName, CallbackWriteData callback)
        {
            /*FileInfo finfo = new FileInfo(fileName);
            if (!finfo.Exists)
            {
                finfo.Create();
            }
            else
            {
                finfo.Delete();
                finfo.Create();
            }*/
            /*if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            File.Create(fileName);
            */
            using (FileStream sw = File.OpenWrite(fileName))
            {
                StreamWriter ss = new StreamWriter(sw);
                callback(ss);
                /*for (int i = 0; i < 100; i++)
                {
                    string strValue = string.Format("D{0:D5}", i);
                    sw.WriteLine(strValue);
                }*/
                ss.Close();
                sw.Close();
            }
        }


        /**
          * write file with configed rowContent
          * 
          * */
        public static void editFileContentByRow(string filePath, int rowNum, string newRow)
        {

            StreamReader sr = new StreamReader(filePath);
            string[] all = sr.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //string oldRow = all[rowId - 1];
            sr.Close();

            StreamWriter sw = new StreamWriter(filePath, false);
            string rowTemp = "";
            for (int i = 0; i < all.Length; i++)
            {
                if (i == rowNum - 1)
                    rowTemp = newRow;
                else
                    rowTemp = all[i];
                sw.WriteLine(rowTemp);
            }
            sw.Flush();
            sw.Close();
        }

        public static string readFileContentByRow(string filePath, int rowNum)
        {
            StreamReader sr = new StreamReader(filePath);
            string[] all = sr.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            sr.Close();

            return all.Length < rowNum ? "": all[rowNum -1];
        }
    }
}
