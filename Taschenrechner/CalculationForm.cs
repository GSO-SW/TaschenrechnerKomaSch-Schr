using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class CalculationForm : Form
    {
        private Calculator calculator;
        public CalculationForm()
        {
            InitializeComponent();
            calculator = new Calculator();
        }
        private void UpdateRichtextBox()
        {
            CalculationRichTextBox.Text = calculator.OperationTask.ToString();
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
            calculator.AppendOperation("0");
            UpdateRichtextBox();

        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            calculator.AppendOperation(".");
            UpdateRichtextBox();

        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            calculator.AppendOperation("+");
            UpdateRichtextBox();

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            CalculationRichTextBox.Text = calculator.Calculate();
        }
    }
}
