 using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows;

namespace Taschenrechner.Misc
{
    public class InterceptKeys
    {
        public delegate void KeyboardCallbackDelegate(Keys key);
        private KeyboardCallbackDelegate keyboardCallback;
        public InterceptKeys(KeyboardCallbackDelegate callback)
        {
            //set our callback, which gets called when input accures
            keyboardCallback = callback;

          //  EventManager.RegisterClassHandler(typeof(Window), Window.KeyUpEvent, new KeyEventHandler(OnKeyInput), true);
        }

        private void OnKeyInput(object sender, KeyEventArgs e)
        {
            keyboardCallback(e.KeyCode);
        }
    }
}
