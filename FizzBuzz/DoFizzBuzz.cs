using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FixxBuzz
{
    public class DoFizzBuzz
    {
        private long _upper;
        private string _labelDiv3;
        private string _labelDiv5;

        public DoFizzBuzz(long upper, string labelDiv3, string labelDiv5)
        {
            _upper = upper;
            _labelDiv3 = labelDiv3;
            _labelDiv5 = labelDiv5;
        }

        public List<string> Exec()
        {
            List<string> results = new List<string>();

            for (long inputvalue = 1; inputvalue < _upper; inputvalue++)
            {
                string theString = GetPrintableString(inputvalue);
                results.Add(theString);
            }

            return results;
        }

        public string GetPrintableString(long inputvalue)
        {
            if (inputvalue % 15 == 0)
                return (_labelDiv3 + " " + _labelDiv5);

            if (inputvalue % 3 == 0)
                return _labelDiv3;

            if (inputvalue % 5 == 0)
                return _labelDiv5;

            return inputvalue.ToString();
        }
    }
}
