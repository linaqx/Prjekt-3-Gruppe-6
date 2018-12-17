using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>
namespace Projekt_3___Desktop
{
    class ComboBoxItem
    {
        string displayValue;
        int hiddenValue;

        //Constructor
        public ComboBoxItem(string d, int h)
        {
            displayValue = d;
            hiddenValue = h;
        }

        //Accessor
        public int HiddenValue
        {
            get
            {
                return hiddenValue;
            }
        }

        public string DisplayValue
        {
            get
            {
                return displayValue;
            }
        }

        //Override ToString method
        public override string ToString()
        {
            return displayValue;
        }
    }
}
