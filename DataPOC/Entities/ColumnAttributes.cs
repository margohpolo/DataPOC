using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPOC.Entities
{
    public class ColumnAttributes
    {
        public string ColumnDefault { get; private set; }
        public string IsNullable { get; private set; }
        public string DataType { get; private set; }
        public string CharMaxLength { get; private set; }
        public string CharDataLength { get; private set; }
        public string NumericPrecision { get; private set; }
        public string NumericScale { get; private set; }
        public string DatetimePrecision { get; private set; }
        public string CharSetName { get; private set; }
        public string CollationName { get; private set; }


        public ColumnAttributes(
            string columnDefault, string isNullable, string dataType, string charMaxLength,
            string charDataLength, string numericPrecision, string numericScale, string datetimePrescision,
            string charSetName, string collationName)
        {
            ColumnDefault = columnDefault;
            IsNullable = isNullable;
            DataType = dataType;
            CharMaxLength = charMaxLength;
            CharDataLength = charDataLength;
            NumericPrecision = numericPrecision;
            NumericScale = numericScale;
            DatetimePrecision = datetimePrescision;
            CharSetName = charSetName;
            CollationName = collationName;
        }

    }
}
