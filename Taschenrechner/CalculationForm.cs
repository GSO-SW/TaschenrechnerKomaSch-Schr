using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taschenrechner.Misc;
namespace Taschenrechner
{
    public partial class CalculationForm : Form
    {
        private Calculator calculator;
        private InterceptKeys keyboardHook;
        public CalculationForm()
        {
            InitializeComponent();
            calculator = new Calculator();
            keyboardHook = new InterceptKeys(ProcessKeyboadInput);
        }
        private void UpdateRichtextBox()
        {
            CalculationRichTextBox.Text = calculator.Expression.ToString();
        }
        private void mcButton_Click(object sender, EventArgs e)
        {

        }

        private void mrButton_Click(object sender, EventArgs e)
        {

        }

        private void msButton_Click(object sender, EventArgs e)
        {

        }

        private void mPlusButton_Click(object sender, EventArgs e)
        {

        }

        private void mMinusButton_Click(object sender, EventArgs e)
        {

        }

        private void eraseLastEntryButton_Click(object sender, EventArgs e)
        {
            calculator.EraseLastOperation();
            UpdateRichtextBox();
        }

        private void clearEntryButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private void plusMinusButton_Click(object sender, EventArgs e)
        {

        }

        private void algRootButton_Click(object sender, EventArgs e)
        {

        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            calculator.AppendOperation("7");
            UpdateRichtextBox();

        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            calculator.AppendOperation("8");
            UpdateRichtextBox();

        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            calculator.AppendOperation("9");
            UpdateRichtextBox();

        }

        private void devideButton_Click(object sender, EventArgs e)
        {
            calculator.AppendOperation("/");
            UpdateRichtextBox();

        }

        private void modButton_Click(object sender, EventArgs e)
        {
            calculator.AppendOperation("%");
            UpdateRichtextBox();

        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            calculator.AppendOperation("4");
            UpdateRichtextBox();

        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            calculator.AppendOperation("5");
            UpdateRichtextBox();

        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            calculator.AppendOperation("6");
            UpdateRichtextBox();

        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            calculator.AppendOperation("*");
            UpdateRichtextBox();

        }

        private void oneDevidXButton_Click(object sender, EventArgs e)
        {
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            calculator.AppendOperation("1");
            UpdateRichtextBox();

        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            calculator.AppendOperation("2");
            UpdateRichtextBox();

        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            calculator.AppendOperation("3");
            UpdateRichtextBox();

        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            calculator.AppendOperation("-");
            UpdateRichtextBox();

        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            AppendOperation("0");
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            AppendOperation(".");
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            AppendOperation("+");
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            CalculationRichTextBox.Text = calculator.Calculate();
        }
        private void AppendOperation(string op)
        {
            calculator.AppendOperation("5");
            UpdateRichtextBox();
        }
        private void ProcessKeyboadInput(Keys key)
        {
            switch (key)
            {
                //case Keys.D0:
                //case Keys.D1:
                //case Keys.D2:
                //case Keys.D3:
                //case Keys.D4:
                //case Keys.D5:
                //case Keys.D6:
                //case Keys.D7:
                //case Keys.D8:
                //case Keys.D9:
                //    AppendOperation(e.KeyCode.ToString());
                //    break;
                //default:
                //    break;
            }
        }
    }
}
