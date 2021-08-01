using System;
using System.Windows.Forms;

namespace BestOil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbx_Oils_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Oils.SelectedItem.ToString() == "Ai-92") lbl_OilsPrice.Text = "1,0";
            else if (cbx_Oils.SelectedItem.ToString() == "Ai-95 (Premium)") lbl_OilsPrice.Text = "1,45";
            else if (cbx_Oils.SelectedItem.ToString() == "Ai-98 (Super Premium)") lbl_OilsPrice.Text = "1,60";
            else if (cbx_Oils.SelectedItem.ToString() == "Diesel") lbl_OilsPrice.Text = "0,60";
            else if (cbx_Oils.SelectedItem.ToString() == "LMG (Metan)") lbl_OilsPrice.Text = "0,45";
            else if (cbx_Oils.SelectedItem.ToString() == "LPG (Propan)") lbl_OilsPrice.Text = "0,60";
            mbx_Litr_TextChanged(this, e);
            mbx_Money_TextChanged(this, e);
        }

        private void rbtn_Amount_CheckedChanged(object sender, EventArgs e)
        {
            mbx_Money.Enabled = false;
            mbx_Money.Text = null;
            lbl_Total.Text = lbl_GasStationSum.Text = "0,00";
            mbx_Litr.Enabled = true;
        }

        private void mbx_Litr_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbx_Oils.SelectedItem?.ToString())
                && !string.IsNullOrEmpty(lbl_OilsPrice?.Text)
                && !string.IsNullOrWhiteSpace(mbx_Litr?.Text))
            {
                lbl_GasStationSum.Text = (decimal.Parse(lbl_OilsPrice.Text) * decimal.Parse(mbx_Litr.Text)).ToString();
                lbl_Total.Text = (decimal.Parse(lbl_GasStationSum.Text) + decimal.Parse(lbl_CafeSum?.Text)).ToString();
            }
        }

        private void rbtn_Money_CheckedChanged(object sender, EventArgs e)
        {
            mbx_Litr.Enabled = false;
            mbx_Litr.Text = null;
            lbl_Total.Text = lbl_GasStationSum.Text = "0,00";
            mbx_Money.Enabled = true;
        }

        private void mbx_Money_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbx_Oils.SelectedItem?.ToString()) 
                && !string.IsNullOrEmpty(lbl_OilsPrice?.Text) 
                && !string.IsNullOrWhiteSpace(mbx_Money?.Text))
            {
                lbl_GasStationSum.Text = mbx_Money.Text;
                lbl_Total.Text = (decimal.Parse(lbl_GasStationSum.Text) + decimal.Parse(lbl_CafeSum?.Text)).ToString();
            }
        }

        private void CheckedProccess(object sender, EventArgs e)
        {
            _ = cbx_Hotdog.Checked ? mbx_HotdogAmount.Enabled = true : mbx_HotdogAmount.Enabled = false;
            _ = cbx_Hamburger.Checked ? mbx_HamburgerAmount.Enabled = true : mbx_HamburgerAmount.Enabled = false;
            _ = cbx_Free.Checked ? mbx_FreeAmount.Enabled = true : mbx_FreeAmount.Enabled = false;
            _ = cbx_CocaCola.Checked ? mbx_CocaColaAmount.Enabled = true : mbx_CocaColaAmount.Enabled = false;
            if (!cbx_Hotdog.Checked) mbx_HotdogAmount.Text = null;
            if (!cbx_Hamburger.Checked) mbx_HamburgerAmount.Text = null;
            if (!cbx_Free.Checked) mbx_FreeAmount.Text = null;
            if (!cbx_CocaCola.Checked) mbx_CocaColaAmount.Text = null;
        }

        private void MultiplyChanged(object sender, EventArgs e)
        {
            decimal a, b, c, d;
            a = b = c = d = default;
            if (!string.IsNullOrEmpty(mbx_HotdogAmount.Text)) a = decimal.Parse(mbx_HotdogAmount.Text) * decimal.Parse(lbl_HotdogPrice.Text);
            if (!string.IsNullOrEmpty(mbx_HamburgerAmount.Text)) b = decimal.Parse(mbx_HamburgerAmount.Text) * decimal.Parse(lbl_HamburgerPrice.Text);
            if (!string.IsNullOrEmpty(mbx_FreeAmount.Text)) c = decimal.Parse(mbx_FreeAmount.Text) * decimal.Parse(lbl_FreePrice.Text);
            if (!string.IsNullOrEmpty(mbx_CocaColaAmount.Text)) d = decimal.Parse(mbx_CocaColaAmount.Text) * decimal.Parse(lbl_CocaColaPrice.Text);
            lbl_CafeSum.Text = (a + b + c + d).ToString();
            lbl_Total.Text = (decimal.Parse(lbl_GasStationSum?.Text) + decimal.Parse(lbl_CafeSum.Text)).ToString();
        }
    }
}