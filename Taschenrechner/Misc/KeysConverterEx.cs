using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner.Misc
{
    class KeysConverterEx
    {
        private KeysConverter keyConverter;

        public KeysConverterEx()
        {
            keyConverter = new KeysConverter();
        }
        /// <summary>
        /// Converts a key into a string, only keys from 0-9 and math basic operations
        /// </summary>
        /// <param name="key">Key to convert</param>
        /// <returns>key in plaintext</returns>
        public string ConvertMathKeyToString(Keys key)
        {
            switch (key)
            {
                case Keys.D0:
                case Keys.D1:
                case Keys.D2:
                case Keys.D3:
                case Keys.D4:
                case Keys.D5:
                case Keys.D6:
                case Keys.D7:
                case Keys.D8:
                case Keys.D9:
                    return (keyConverter.ConvertToString(key));
                case Keys.Add:
                case Keys.Oemplus:
                    return "+";
                case Keys.OemMinus:
                case Keys.Subtract:
                    return "-";
                case Keys.Multiply:
                case Keys.Divide:
                    return "/";
                default:
                    return string.Empty;
            }
        }
    }
}
