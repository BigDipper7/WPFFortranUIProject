using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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


    }
}
