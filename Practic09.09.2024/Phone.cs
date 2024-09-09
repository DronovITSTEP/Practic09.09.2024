using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic09._09._2024
{
    class Phone
    {
        private string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        public int MyProperty { get; private set; }

        private string _vendor;
        private int _weidth;
        private string _color;

        public string Vendor
        {
            get
            {
                return _vendor;
            }
            set
            {
                if (value == "Apple" || value == "iPhone")
                    _vendor = value;
            }
        }
        public int Weidth
        {
            get { return _weidth; }
            set { _weidth = value; }
        }
        public string Model { private get; set; }

        private string _model;
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }


        public void SetColor(string c)
        {
            if (c == "red" || c == "black")
                _color = c;
        }
        public string GetVendor()
        {
            return _vendor;
        }
        public bool Call(string numberPhone)
        {
           
            if (!string.IsNullOrEmpty(numberPhone))
                return true;

            return false;
        }
        private int AnaliticData()
        {
            return 10;
        }
    }
}
