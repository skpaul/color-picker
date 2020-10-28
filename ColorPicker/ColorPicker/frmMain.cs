using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.ColorBucketIco48;
        }

        private void ChangeColor(Color MyColor)
        {
            this.BackColor = MyColor;

            if (chkColor1.CheckState == CheckState.Checked)
            {
                splitContainer4.Panel1.BackColor = MyColor;
                chkColor1.Text = txtRed.Text + "," + txtGreen.Text + "," + txtBlue.Text;
            }

            if (chkColor2.CheckState == CheckState.Checked)
            {
                splitContainer5.Panel1.BackColor = MyColor;
                chkColor3.Text = txtRed.Text + "," + txtGreen.Text + "," + txtBlue.Text;
            }

            if (chkColor3.CheckState == CheckState.Checked)
            {
                splitContainer4.Panel2.BackColor = MyColor;
                chkColor2.Text = txtRed.Text + "," + txtGreen.Text + "," + txtBlue.Text;
            }

            if (chkColor4.CheckState == CheckState.Checked)
            {
                splitContainer5.Panel2.BackColor = MyColor;
                chkColor4.Text = txtRed.Text + "," + txtGreen.Text + "," + txtBlue.Text;
            }
        }

        private void RedBar_Scroll(object sender, EventArgs e)
        {
            txtRed.Text =RedBar.Value.ToString();
            Color ColorName = new Color();
            ColorName = Color.FromArgb(Convert.ToInt32(txtRed.Text), Convert.ToInt32(txtGreen.Text), Convert.ToInt32(txtBlue.Text));
            ChangeColor(ColorName);
        }

        private void GreenBar_Scroll(object sender, EventArgs e)
        {
            txtGreen.Text = GreenBar.Value.ToString();
            Color ColorName = new Color();
            ColorName = Color.FromArgb(Convert.ToInt32(txtRed.Text), Convert.ToInt32(txtGreen.Text), Convert.ToInt32(txtBlue.Text));
            ChangeColor(ColorName);
        }

        private void BlueBar_Scroll(object sender, EventArgs e)
        {
            txtBlue.Text = BlueBar.Value.ToString();
            Color ColorName = new Color();
            ColorName = Color.FromArgb(Convert.ToInt32(txtRed.Text), Convert.ToInt32(txtGreen.Text), Convert.ToInt32(txtBlue.Text));
            ChangeColor(ColorName);
        }

        private void txtColorName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode==Keys.Enter)
                {
                    string ColorName = txtColorName.Text.Trim();
                    Color color = System.Drawing.ColorTranslator.FromHtml(ColorName);
                    int r = color.R;
                    int g = color.G;
                    int b = color.B;

                    txtRed.Text = r.ToString();
                    txtGreen.Text = g.ToString();
                    txtBlue.Text = b.ToString();

                    RedBar.Value = r;
                    GreenBar.Value = g;
                    BlueBar.Value = b;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}
