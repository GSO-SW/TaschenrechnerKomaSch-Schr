 using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows;

namespace Taschenrechner.Misc
{
    public class InterceptKeys
    {
        public delegate void KeyboardCallbackDelegate(KeyEventArgs keyEvent);
        private KeyboardCallbackDelegate keyboardCallback;

        /// <summary>
        /// Registers the callback KeyUp on the given form
        /// </summary>
        /// <param name="form">Form on which the Keyboard input is performed</param>
        /// <param name="callback">Callback which is called on the input</param>
        public InterceptKeys(Form form, KeyboardCallbackDelegate callback)
        {
            //set our callback, which gets called when input accures
            keyboardCallback = callback;
            form.KeyPreview = true;
            form.KeyUp += Form_KeyUp;
        }

        private void Form_KeyUp(object sender, KeyEventArgs e)
        {
            keyboardCallback(e);
        }
    }
}
