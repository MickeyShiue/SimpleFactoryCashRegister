using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFactoryCashRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxType.Items.AddRange(new object[] { "Normal","Over300toSend100", "Discount", "Over500toSend200" });
            cbxType.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CashSuper cusper = CashFactory.CreateClass(cbxType.SelectedItem.ToString());
            double totalPrice = 0;
            totalPrice = cusper.CountMoney(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtQty.Text));
            ResultListBox.Items.Add("單價：" + txtPrice.Text + " 書量：" + txtQty.Text + " 合計：" + totalPrice.ToString());

            lblResult.Text = totalPrice.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResultListBox.Items.Clear();
            lblResult.Text = string.Empty;
        }
    }
}
