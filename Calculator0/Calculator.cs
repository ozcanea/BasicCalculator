using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator0
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtPrint.Text += b.Text;
        }
        void TakeStringWithoutSigns()
        {
            lblPrevious.Text = lblPrevious.Text.Substring(0, lblPrevious.Text.Length - 1);
        }
        void OperatorsWithNum(Button button)
        {
            
            switch (button.Text)
                {
                    case "+":
                        lblPrevious.Text = (Convert.ToDouble(lblPrevious.Text) + Convert.ToDouble(txtPrint.Text)).ToString();
                break;
                    case "-":
                        lblPrevious.Text = (Convert.ToDouble(lblPrevious.Text) - Convert.ToDouble(txtPrint.Text)).ToString();
                break;
                    case "*":
                        lblPrevious.Text = (Convert.ToDouble(lblPrevious.Text) * Convert.ToDouble(txtPrint.Text)).ToString();
                break;
                    case "/":
                        lblPrevious.Text = (Convert.ToDouble(lblPrevious.Text) / Convert.ToDouble(txtPrint.Text)).ToString();
                break;
            }
        }
        void OperatorsWithoutNum(Button button)
        {
            switch (button.Text)
            {
                case "+":
                    lblPrevious.Text = (Convert.ToDouble(lblPrevious.Text) + Convert.ToDouble(lblPrevious.Text)).ToString() ;
                    break;
                case "-":
                    lblPrevious.Text = (Convert.ToDouble(lblPrevious.Text) - Convert.ToDouble(lblPrevious.Text)).ToString();
                    break;
                case "*":
                    lblPrevious.Text = (Convert.ToDouble(lblPrevious.Text) * Convert.ToDouble(lblPrevious.Text)).ToString();
                    break;
                case "/":
                    lblPrevious.Text = (Convert.ToDouble(lblPrevious.Text) / Convert.ToDouble(lblPrevious.Text)).ToString();
                    break;
            }

        }

        private void btnClickSign(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (lblPrevious.Text != "" && txtPrint.Text != "")
            {
                TakeStringWithoutSigns();
                OperatorsWithNum(button);
                lblPrevious.Text = lblPrevious.Text + button.Text;

            }
            else if (lblPrevious.Text != "" && txtPrint.Text == "")
            {
                TakeStringWithoutSigns();
                OperatorsWithoutNum(button);
                
            }
            else if (lblPrevious.Text==""&&txtPrint.Text=="0")
            {
                MessageBox.Show("Please Enter A Number First");
               
            }
            else
            {
                lblPrevious.Text = txtPrint.Text + button.Text;
            }
            txtPrint.Text = "";

        }

        private void btnClickClear(object sender, EventArgs e)
        {
            lblPrevious.Text = "";
            txtPrint.Text = "0";
        }

        private void btnClickEquals(object sender, EventArgs e)
        {
            if (lblPrevious.Text!=""&&txtPrint.Text!="")
            {
                string sign = lblPrevious.Text.Substring(lblPrevious.Text.Length - 1,1);
                switch (sign)
                {
                    case "+":
                        lblPrevious.Text = (Convert.ToDouble(lblPrevious.Text) + Convert.ToDouble(lblPrevious.Text)).ToString();
                        break;
                    case "-":
                        lblPrevious.Text = (Convert.ToDouble(lblPrevious.Text) - Convert.ToDouble(lblPrevious.Text)).ToString();
                        break;
                    case "*":
                        lblPrevious.Text = (Convert.ToDouble(lblPrevious.Text) * Convert.ToDouble(lblPrevious.Text)).ToString();
                        break;
                    case "/":
                        lblPrevious.Text = (Convert.ToDouble(lblPrevious.Text) / Convert.ToDouble(lblPrevious.Text)).ToString();
                        break;
                }
                txtPrint.Text = lblPrevious.Text;
                lblPrevious.Text = "";
            }
        }
    }
}
