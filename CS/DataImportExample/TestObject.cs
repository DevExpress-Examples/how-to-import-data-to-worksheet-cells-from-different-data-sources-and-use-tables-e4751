using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataImportExample
{
    #region #testobject
    class TestObject
    {
        public TestObject(int intValue, string value, bool boolValue)
        {
            this.intValue = intValue;
            this.Value = value;
            this.BoolValue = boolValue;

        }
        public int intValue;
        private int privateValue { get { return 123; } }
        public int IntValue { get { return intValue + privateValue - 123; } }
        public string Value { get; set; }
        public bool BoolValue { get; set; }
        public int this[int index] { get { return index; } }
    }
    #endregion #testobject
}
