using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scientificCalculator
{
    public partial class Form1 : Form
    {

        Double results = 0;
        String operation = "";
        bool enter_value = false;
        float iCelcius, iFahrenheit, iKelvin;
        char iOperation;
       



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 325;
            txbDisplay.Width = 286;
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 325;
            txbDisplay.Width = 286;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 650;
            txbDisplay.Width = 605;
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1030;
            txbDisplay.Width = 605;
            txbEnterValueConvert.Focus();

            gbTemperature.Visible = true;
            gbMultiplication.Visible = false;

        }

        private void unitConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1030;
            txbDisplay.Width = 605;
        }

        private void multiplicationTimetableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1030;
            txbDisplay.Width = 605;
            txbMultiply.Focus();
            gbTemperature.Visible = false;
            gbMultiplication.Visible = true;

            gbMultiplication.Location = new Point(652, 41);
            gbMultiplication.Width = 342;
            gbMultiplication.Height = 358;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txbDisplay.Text == "0") || (enter_value))
                txbDisplay.Text = "";
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txbDisplay.Text.Contains("."))
                    txbDisplay.Text = txbDisplay.Text + num.Text;
            }
            else
                txbDisplay.Text = txbDisplay.Text + num.Text;
        }

        private void btnClearEverything_Click(object sender, EventArgs e)
        {
            txbDisplay.Text = "0";
            lblShowUp.Text = "";
        }
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txbDisplay.Text.Length > 0)
            {
                txbDisplay.Text = txbDisplay.Text.Remove(txbDisplay.Text.Length - 1, 1);
            }

            if (txbDisplay.Text == "")
            {
                txbDisplay.Text = "0";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            txbDisplay.Text = "0";
            lblShowUp.Text = "";
        }



        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(txbDisplay.Text);
            txbDisplay.Text = "";
            lblShowUp.Text = System.Convert.ToString(results) + " " + operation;

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            lblShowUp.Text = "";
            switch (operation)
            {
                case "+":
                    txbDisplay.Text = (results + Double.Parse(txbDisplay.Text)).ToString();
                    break;
                case "-":
                    txbDisplay.Text = (results - Double.Parse(txbDisplay.Text)).ToString();
                    break;
                case "x":
                    txbDisplay.Text = (results * Double.Parse(txbDisplay.Text)).ToString();
                    break;
                case "÷":
                    txbDisplay.Text = (results / Double.Parse(txbDisplay.Text)).ToString();
                    break;
                case "Mod":
                    txbDisplay.Text = (results % Double.Parse(txbDisplay.Text)).ToString();
                    break;
                case "Exp":
                    double i = Double.Parse(txbDisplay.Text);
                    double q;
                    q = (results);
                    txbDisplay.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            const double Pi = 3.14159265359;
            txbDisplay.Text = Pi.ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txbDisplay.Text);
            lblShowUp.Text = System.Convert.ToString("log" + "(" + (txbDisplay.Text) + ")");
            ilog = Math.Log10(ilog);
            txbDisplay.Text = System.Convert.ToString(ilog);
           
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double Sqrt = Double.Parse(txbDisplay.Text);
            lblShowUp.Text = System.Convert.ToString("Sqrt" + "(" + (txbDisplay.Text) + ")");
            Sqrt = Math.Sqrt(Sqrt);
            txbDisplay.Text = System.Convert.ToString(Sqrt);

        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            double qSinh = Double.Parse(txbDisplay.Text);
            lblShowUp.Text = System.Convert.ToString("Sinh" + "(" + (txbDisplay.Text) + ")");
            qSinh = Math.Sinh(qSinh);
            txbDisplay.Text = System.Convert.ToString(qSinh);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double qSin = Double.Parse(txbDisplay.Text);
            lblShowUp.Text = System.Convert.ToString("Sin" + "(" + (txbDisplay.Text) + ")");
            qSin = Math.Sin(qSin);
            txbDisplay.Text = System.Convert.ToString(qSin);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double qCosh = Double.Parse(txbDisplay.Text);
            lblShowUp.Text = System.Convert.ToString("Cosh" + "(" + (txbDisplay.Text) + ")");
            qCosh = Math.Cosh(qCosh);
            txbDisplay.Text = System.Convert.ToString(qCosh);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double qCos = Double.Parse(txbDisplay.Text);
            lblShowUp.Text = System.Convert.ToString("Cos" + "(" + (txbDisplay.Text) + ")");
            qCos = Math.Cos(qCos);
            txbDisplay.Text = System.Convert.ToString(qCos);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            double qTanh = Double.Parse(txbDisplay.Text);
            lblShowUp.Text = System.Convert.ToString("Tanh" + "(" + (txbDisplay.Text) + ")");
            qTanh = Math.Tanh(qTanh);
            txbDisplay.Text = System.Convert.ToString(qTanh);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double qTan = Double.Parse(txbDisplay.Text);
            lblShowUp.Text = System.Convert.ToString("Tan" + "(" + (txbDisplay.Text) + ")");
            qTan = Math.Tan(qTan);
            txbDisplay.Text = System.Convert.ToString(qTan);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txbDisplay.Text);
            txbDisplay.Text = System.Convert.ToString(a, 2);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txbDisplay.Text);
            txbDisplay.Text = System.Convert.ToString(a, 16);
        }

        private void bntOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txbDisplay.Text);
            txbDisplay.Text = System.Convert.ToString(a, 8);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txbDisplay.Text);
            txbDisplay.Text = System.Convert.ToString(a);
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txbDisplay.Text) * Convert.ToDouble(txbDisplay.Text);
            txbDisplay.Text = System.Convert.ToString(a);
        }

        private void btnx3_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txbDisplay.Text) * Convert.ToDouble(txbDisplay.Text) * Convert.ToDouble(txbDisplay.Text);
            txbDisplay.Text = System.Convert.ToString(a);
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0 /  Convert.ToDouble(txbDisplay.Text));
            txbDisplay.Text = System.Convert.ToString(a);
        }

        private void btnInx_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txbDisplay.Text);
            ilog = Math.Log(ilog);
            txbDisplay.Text = System.Convert.ToString(ilog);
        }

        private void rbtnCelciusFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'C';
        }

        private void rbtnFarenheitCelcius_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'F';
        }

        private void rbtnKelvin_CheckedChanged(object sender, EventArgs e)
        {
            iOperation = 'K';
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txbEnterValueConvert.Clear();
            lblConverted.Text = "";
            rbtnCelciusFahrenheit.Checked = false;
            rbtnFarenheitCelcius.Checked = false;
            rbtnKelvin.Checked = false;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(txbMultiply.Text);

            for (int i = 1; i < 13; i++) 
            {

                lstMultiplication.Items.Add(i + " x" + a + " =" + a * i);

            }
        }

        private void btnResetM_Click(object sender, EventArgs e)
        {
            lstMultiplication.Items.Clear();
            txbMultiply.Clear();
        }

        private void btnPcnt_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txbDisplay.Text) / Convert.ToDouble(100);
            txbDisplay.Text = System.Convert.ToString(a);

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            switch(iOperation)
            {

                case 'C':
                    //Calcius to fahrenheit
                    iCelcius = float.Parse(txbEnterValueConvert.Text);
                    lblConverted.Text = ((((9 * iCelcius) / 5) + 32).ToString());
                    break;

                case 'F':
                    // Fahrenheit to Calcius
                    iFahrenheit = float.Parse(txbEnterValueConvert.Text);
                    lblConverted.Text = ((((iFahrenheit - 32) * 5) / 9).ToString());
                    break;

                case 'K':
                    //Calcius to fahrenheit
                    iKelvin = float.Parse(txbEnterValueConvert.Text);
                    lblConverted.Text = ((((9 * iKelvin) / 5) + 273.15).ToString());
                    break;


            }
        }
    }

        

   }

        
