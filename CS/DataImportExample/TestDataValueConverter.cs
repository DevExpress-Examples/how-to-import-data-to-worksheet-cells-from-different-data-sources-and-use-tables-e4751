using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataImportExample
{
    #region #converter
    class TestDataValueConverter : DevExpress.Spreadsheet.IDataValueConverter
    {
        public bool TryConvert(object value, int columnIndex, out DevExpress.Spreadsheet.CellValue result)
        {
            string strValue = value as string;
            if (strValue != null)
            {
                int str2int;
                bool success = Int32.TryParse(strValue, out str2int);
                result = success ? str2int : 0;
                return true;
            }
            Type valueType = value.GetType();
            if (valueType == typeof(int))
                result = (int)value;
            else
                result = null;
            return true;
        }
    }
    #endregion #converter
}
