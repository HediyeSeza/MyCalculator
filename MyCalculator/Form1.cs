using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Calculator : Form
    {
        ICalculator calculator;
        public Calculator()
        {
            InitializeComponent();
            calculator = new Calculate();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int sum = calculator.plus((int)txtNamber1.Value, (int)txtNamber2.Value);
                MessageBox.Show("Sum is :" + sum);
            }
        }
        bool ValidateInput()
        {
            bool isValid = true;

            if (txtNamber1.Value == 0)
            {
                isValid = false;
                MessageBox.Show("لطفا عدد اول را وارد کنید");
            }
            else
            {
                if (txtNamber2.Value == 0)
                {
                    isValid = false;
                    MessageBox.Show("لطفا عدد دوم را وارد کنید");
                }
            }
            return isValid;
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int minus = calculator.minus((int)txtNamber1.Value, (int)txtNamber2.Value);
                MessageBox.Show("minus is:" + minus);
            }
        }

        private void btnmultiple_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int multiple = calculator.multiple((int)txtNamber1.Value, (int)txtNamber2.Value);
                MessageBox.Show("multiple is:" + multiple);
            }
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int divide = calculator.divide((int)txtNamber1.Value, (int)txtNamber2.Value);
                MessageBox.Show("divide is:" + divide);
            }
        }

    }
}

