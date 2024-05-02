using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily family in FontFamily.Families)
            {
                cmbFont.Items.Add(family.Name);
            }
        }

        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFont.SelectedIndex == -1)
            {
                return;
            }
            string familyname = cmbFont.Text;
            lblFont.Font = new Font(familyname, 9);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowHelp = true;
            dialog.FullOpen = true;
            try
            {
                if (dialog.ShowDialog() == DialogResult.Cancel)
                {
                    throw new Exception("Color selection is required");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            lblColor1.BackColor = dialog.Color;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                switch (button.Name)
                {
                    case "btnTopLeft":
                        lblBottomMessage.TextAlign = ContentAlignment.TopLeft;
                        break;
                    case "btnTopCenter":
                        lblBottomMessage.TextAlign = ContentAlignment.TopCenter;
                        break;
                    case "btnTopRight":
                        lblBottomMessage.TextAlign = ContentAlignment.TopRight;
                        break;
                    case "btnLeft":
                        lblBottomMessage.TextAlign = ContentAlignment.MiddleLeft;
                        break;
                    case "btnCenter":
                        lblBottomMessage.TextAlign = ContentAlignment.MiddleCenter;
                        break;
                    case "btnRight":
                        lblBottomMessage.TextAlign = ContentAlignment.MiddleRight;
                        break;
                    case "btnBottomLeft":
                        lblBottomMessage.TextAlign = ContentAlignment.BottomLeft;
                        break;
                    case "btnBottomCenter":
                        lblBottomMessage.TextAlign = ContentAlignment.BottomCenter;
                        break;
                    case "btnBottomRight":
                        lblBottomMessage.TextAlign = ContentAlignment.BottomRight;
                        break;

                }
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            lblBottomMessage.Text = txtMessage.Text;
            lblBottomMessage.ForeColor = lblColor1.BackColor;
            FontStyle style = FontStyle.Regular;
            if (chkBold.Checked)
            {
                style = style | FontStyle.Bold;
            }
            if (chkItalic.Checked)
            {
                style = style | FontStyle.Italic;
            }
            lblBottomMessage.Font = new Font(cmbFont.Text, (int)numericUpDown1.Value, style);

            try
            {
                if (String.IsNullOrEmpty(txtMessage.Text))
                    throw new Exception("Please enter your message!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
