using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtnum1.Text, out double num1) && double.TryParse(txtnum2.Text, out double num2))
            {
                string selectedOperator = cmbOperator.SelectedItem.ToString();
                double result = 0;
                if(selectedOperator=="+")
                {
                    result = num1 + num2;
                }
                else if(selectedOperator=="-")
                {
                    result = num1 - num2;
                }
                else if(selectedOperator=="*")
                {
                    result = num1 * num2;
                }
                else if(selectedOperator=="/")
                {
                    if(num2!=0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("除数不能为零", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                lblResult.Text = $"结果为：{result}";
            }
            else
            {
                MessageBox.Show("请输入有效的数字", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
