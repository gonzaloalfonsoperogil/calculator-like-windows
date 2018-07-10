using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmCalculator : Form
    {
        bool res = false, unaria = false;
        bool hayRes = false, numero = true;
        double opr1 = 0, opr2 = 0;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        string operation = "+";
        double memoria;
        bool ContDigits(int longitud)
        {
            if (longitud <= 16)
            {
                return true;
            }else
            {
                return false;
            }
        }
        public frmCalculator()
        {
            InitializeComponent();
            label1.Visible = false;
        }
        void Botones(object sender)
        {
            try
            {
                Button btn = sender as Button;

                switch (btn.Name)
                {
                    case "btnOne":
                        vaciarResultado();
                        if (ContDigits(txtInput.Text.Length)) txtInput.Text += "1";
                        numero = true;
                        break;
                    case "btnTwo":
                        vaciarResultado();
                        if (ContDigits(txtInput.Text.Length)) txtInput.Text += "2";
                        numero = true;
                        break;
                    case "btnThree":
                        vaciarResultado();
                        if (ContDigits(txtInput.Text.Length)) txtInput.Text += "3";
                        numero = true;
                        break;
                    case "btnFour":
                        vaciarResultado();
                        if (ContDigits(txtInput.Text.Length)) txtInput.Text += "4";
                        numero = true;
                        break;
                    case "btnFive":
                        vaciarResultado();
                        if (ContDigits(txtInput.Text.Length)) txtInput.Text += "5";
                        numero = true;
                        break;
                    case "btnSix":
                        vaciarResultado();
                        if (ContDigits(txtInput.Text.Length)) txtInput.Text += "6";
                        numero = true;
                        break;
                    case "btnSeven":
                        vaciarResultado();
                        if (ContDigits(txtInput.Text.Length)) txtInput.Text += "7";
                        numero = true;
                        break;
                    case "btnEight":
                        vaciarResultado();
                        if (ContDigits(txtInput.Text.Length)) txtInput.Text += "8";
                        numero = true;
                        break;
                    case "btnNine":
                        vaciarResultado();
                        if (ContDigits(txtInput.Text.Length)) txtInput.Text += "9";
                        numero = true;
                        break;
                    case "btnZero":
                        vaciarResultado();
                        if (ContDigits(txtInput.Text.Length)) txtInput.Text += "0";
                        numero = true;
                        break;
                    case "btnDot":
                        if (!txtInput.Text.Contains("."))
                        {
                            vaciarResultado();
                            txtInput.Text += ".";
                        }
                        break;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry for the inconvenience, Unexpected error occured. Details: " +
                    ex.Message);
            }
        }
        private void frmCalculator_Load(object sender, EventArgs e)
        {
            btnOne.Click += new EventHandler(btn_Click);
            btnTwo.Click += new EventHandler(btn_Click);
            btnThree.Click += new EventHandler(btn_Click);
            btnFour.Click += new EventHandler(btn_Click);
            btnFive.Click += new EventHandler(btn_Click);
            btnSix.Click += new EventHandler(btn_Click);
            btnSeven.Click += new EventHandler(btn_Click);
            btnEight.Click += new EventHandler(btn_Click);
            btnNine.Click += new EventHandler(btn_Click);
            btnZero.Click += new EventHandler(btn_Click);
            btnDot.Click += new EventHandler(btn_Click);
        }
        void vaciarResultado()
        {
            if (res)
            {
                txtInput.Text = string.Empty;
                res = false;
            }
            else if (txtInput.Text == "0")
            {
                txtInput.Text = string.Empty;
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            Botones(sender);
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                    vaciarResultado();
                    if (ContDigits(txtInput.Text.Length)) txtInput.Text += "1";
                    numero = true;
                    break;
                case '2':
                    vaciarResultado();
                    if (ContDigits(txtInput.Text.Length)) txtInput.Text += "2";
                    numero = true;
                    break;
                case '3':
                    vaciarResultado();
                    if (ContDigits(txtInput.Text.Length)) txtInput.Text += "3";
                    numero = true;
                    break;
                case '4':
                    vaciarResultado();
                    if (ContDigits(txtInput.Text.Length)) txtInput.Text += "4";
                    numero = true;
                    break;
                case '5':
                    vaciarResultado();
                    if (ContDigits(txtInput.Text.Length)) txtInput.Text += "5";
                    numero = true;
                    break;
                case '6':
                    vaciarResultado();
                    if (ContDigits(txtInput.Text.Length)) txtInput.Text += "6";
                    numero = true;
                    break;
                case '7':
                    vaciarResultado();
                    if (ContDigits(txtInput.Text.Length)) txtInput.Text += "7";
                    numero = true;
                    break;
                case '8':
                    vaciarResultado();
                    if (ContDigits(txtInput.Text.Length)) txtInput.Text += "8";
                    numero = true;
                    break;
                case '9':
                    vaciarResultado();
                    if (ContDigits(txtInput.Text.Length)) txtInput.Text += "9";
                    numero = true;
                    break;
                case '0':
                    vaciarResultado();
                    if (ContDigits(txtInput.Text.Length)) txtInput.Text += "0";
                    numero = true;
                    break;
                case '+':
                    Sumar();
                    break;
                case '-':
                    Restar();
                    break;
                case '*':
                    Multiplicar();
                    break;
                case '/':
                    Dividir();
                    break;
                case '.':
                    vaciarResultado();
                    txtInput.Text += ".";
                    numero = true;
                    break;
                case (char)Keys.Back:
                    txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1);
                    break;
                case (char)Keys.Enter:
                    Igualar();
                    break;
                default:
                    e.Handled = true;
                    MessageBox.Show("Only numbers, +, -, ., *, / are allowed");
                    break;
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Sumar();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Restar();
        }

        private void btnMulitply_Click(object sender, EventArgs e)
        {
            Multiplicar();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Dividir();
        }

        void Operacion()
        {
            if (operation == "-")
            {

                if (!unaria)
                {
                    opr2 = Double.Parse(txtInput.Text, CultureInfo.InvariantCulture);
                    opr1 -= opr2;
                    operand1 = txtInput.Text;
                    textBox1.Text += opr2.ToString(CultureInfo.InvariantCulture);
                }

            }
            else if (operation == "+")
            {

                if (!unaria)
                {
                    opr2 = Double.Parse(txtInput.Text, CultureInfo.InvariantCulture);
                    opr1 += opr2;
                    operand1 = txtInput.Text;
                    textBox1.Text += opr2.ToString(CultureInfo.InvariantCulture);
                }

            }
            else if (operation == "*")
            {

                if (!unaria)
                {
                    opr2 = Double.Parse(txtInput.Text, CultureInfo.InvariantCulture);
                    opr1 *= opr2;
                    operand1 = txtInput.Text;
                    textBox1.Text += opr2.ToString(CultureInfo.InvariantCulture);
                }

            }
            else if (operation == "/")
            {

                if (!unaria)
                {
                    opr2 = Double.Parse(txtInput.Text, CultureInfo.InvariantCulture);
                    opr1 /= opr2;
                    operand1 = txtInput.Text;
                    textBox1.Text += opr2.ToString();
                }

            }
        }

        void OperacionBinaria(string operacion)
        {
            switch (operacion)
            {
                case "+":
                    opr1 += opr2;
                    break;
                case "-":
                    opr1 -= opr2;
                    break;
                case "*":
                    opr1 *= opr2;
                    break;
                case "/":
                    opr1 /= opr2;
                    break;
            }
        }

        void Inversa()
        {
            if (txtInput.Text.Length > 0)
            {
                if (hayRes)
                {
                    opr2 = Double.Parse(txtInput.Text, CultureInfo.InvariantCulture);
                    textBox1.Text += "reciproc(" + txtInput.Text + ")";
                    opr2 = 1/double.Parse(txtInput.Text);
                    OperacionBinaria(operation);
                }
                else
                {
                    opr1 = 1/(Double.Parse(txtInput.Text, CultureInfo.InvariantCulture));
                    hayRes = true;
                    textBox1.Text += "reciproc(" + txtInput.Text + ")";
                }

            }
            else
            {
                opr1 = 0;
                textBox1.Text += "reciproc(" + txtInput.Text + ")";
            }
            txtInput.Text = string.Empty;
            txtInput.Text = opr1.ToString(CultureInfo.InvariantCulture);
            numero = true;
            res = true;
            unaria = true;
        }

        void RaizCuadrada()
        {
            if (txtInput.Text.Length > 0)
            {
                if (hayRes)
                {
                    opr2 = Double.Parse(txtInput.Text, CultureInfo.InvariantCulture);
                    textBox1.Text += "sqrt(" + txtInput.Text + ")";
                    opr2 = (Math.Sqrt(double.Parse(txtInput.Text)));
                    OperacionBinaria(operation);
                }
                else
                {
                    opr1 = (Math.Sqrt(Double.Parse(txtInput.Text, CultureInfo.InvariantCulture)));
                    hayRes = true;
                    textBox1.Text += "sqrt(" + txtInput.Text + ")";
                }

            }
            else
            {
                opr1 = 0;
                textBox1.Text += "sqrt(" + txtInput.Text + ")";
            }
            txtInput.Text = string.Empty;
            txtInput.Text = opr1.ToString(CultureInfo.InvariantCulture);
            numero = true;
            res = true;
            unaria = true;
        }

        void Porcentaje()
        {
            if (txtInput.Text.Length > 0)
            {
                if (hayRes)
                {
                    opr2 = Double.Parse(txtInput.Text, CultureInfo.InvariantCulture);
                    opr2 = opr1*double.Parse(txtInput.Text)/100;
                    textBox1.Text += opr2.ToString(CultureInfo.InvariantCulture);
                    OperacionBinaria(operation);
                }

            }
            txtInput.Text = string.Empty;
            txtInput.Text = opr1.ToString(CultureInfo.InvariantCulture);
            numero = true;
            res = true;
            unaria = true;
        }

        void Sumar()
        {

            if (numero)
            {
                if (txtInput.Text.Length > 0)
                {
                    if (hayRes)
                    {

                        Operacion();
                        textBox1.Text += " + ";
                    }
                    else
                    {
                        opr1 = Double.Parse(txtInput.Text, CultureInfo.InvariantCulture);
                        hayRes = true;
                        textBox1.Text += opr1.ToString(CultureInfo.InvariantCulture) + " + ";
                    }
                }
                else
                {
                    opr1 = 0;
                    textBox1.Text += opr1.ToString(CultureInfo.InvariantCulture) + " + ";
                }
                operation = "+";
                txtInput.Text = string.Empty;
                txtInput.Text = opr1.ToString(CultureInfo.InvariantCulture);
                numero = false;
                unaria = false;
                res = true;
            }

        }

        void Restar()
        {
            if (numero)
            {
                if (txtInput.Text.Length > 0)
                {
                    if (hayRes)
                    {

                        Operacion();
                        textBox1.Text += " - ";
                    }
                    else
                    {
                        opr1 = Double.Parse(txtInput.Text, CultureInfo.InvariantCulture);
                        hayRes = true;
                        textBox1.Text += opr1.ToString(CultureInfo.InvariantCulture) + " - ";
                    }
                }
                else
                {
                    opr1 = 0;
                    textBox1.Text += opr1.ToString(CultureInfo.InvariantCulture) + " - ";
                }
                operation = "-";

                txtInput.Text = string.Empty;
                txtInput.Text = opr1.ToString(CultureInfo.InvariantCulture);
                numero = false;
                unaria = false;
                res = true;
            }
        }

        void Dividir()
        {
            if (numero)
            {
                if (txtInput.Text.Length > 0)
                {
                    if (hayRes)
                    {
                        Operacion();
                        textBox1.Text += " / ";
                    }
                    else
                    {
                        opr1 = Double.Parse(txtInput.Text, CultureInfo.InvariantCulture);
                        hayRes = true;
                        textBox1.Text += opr1.ToString(CultureInfo.InvariantCulture) + " / ";
                    }
                }
                else
                {
                    opr1 = 0;
                    textBox1.Text += opr1.ToString(CultureInfo.InvariantCulture) + " / ";
                }
                operation = "/";
                txtInput.Text = string.Empty;
                txtInput.Text = opr1.ToString(CultureInfo.InvariantCulture);
                numero = false;
                unaria = false;
                res = true;
            }
        }

        void Multiplicar()
        {
            if (numero)
            {
                if (txtInput.Text.Length > 0)
                {
                    if (hayRes)
                    {
                        Operacion();
                        textBox1.Text += " * ";
                    }
                    else
                    {
                        opr1 = Double.Parse(txtInput.Text, CultureInfo.InvariantCulture);
                        hayRes = true;
                        textBox1.Text += opr1.ToString(CultureInfo.InvariantCulture) + " * ";
                    }
                }
                else
                {
                    opr1 = 0;
                    textBox1.Text += opr1.ToString(CultureInfo.InvariantCulture) + " * ";
                }
                operation = "*";
                txtInput.Text = string.Empty;
                txtInput.Text = opr1.ToString(CultureInfo.InvariantCulture);
                numero = false;
                unaria = false;
                res = true;
            }
        }

        void Igualar()
        {
            if (!unaria)
            {
                if (!res)
                {
                    operand2 = txtInput.Text;
                    opr2 = double.Parse(operand2, CultureInfo.InvariantCulture);

                    switch (operation)
                    {
                        case "+":
                            opr1 += opr2;
                            break;

                        case "-":
                            opr1 -= opr2;
                            break;

                        case "*":
                            opr1 *= opr2;
                            break;

                        case "/":
                            if (opr2 != 0)
                            {
                                opr1 /= opr2;
                            }
                            else
                            {
                                MessageBox.Show("Can't divide by zero");
                            }
                            break;
                    }
                    textBox1.Text = string.Empty;
                    txtInput.Text = opr1.ToString(CultureInfo.InvariantCulture);
                    
                    //  initZero = false;

                    hayRes = false;
                   res = true;
                }
            }
            else
            {
                textBox1.Text = string.Empty;
                txtInput.Text = opr1.ToString(CultureInfo.InvariantCulture);
                
                //  initZero = false;

                hayRes = false;
               res = true;
            }
        
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            Igualar();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double aux = Double.Parse(txtInput.Text, CultureInfo.InvariantCulture) * -1;
            txtInput.Text = aux.ToString(CultureInfo.InvariantCulture);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtInput.Text = string.Empty;
            txtInput.Focus();
            opr2 = 0;
        }

        private void btnByFour_Click(object sender, EventArgs e)
        {
            Porcentaje();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            memoria = 0;
            label1.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtInput.Text = memoria.ToString(CultureInfo.InvariantCulture);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "0" && txtInput.Text.Length > 0)
            {
                memoria = Double.Parse(txtInput.Text, CultureInfo.InvariantCulture);
                label1.Visible = true;
            }
            if (memoria == 0)
            {
                label1.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "0" && txtInput.Text.Length > 0)
            {
                memoria += Double.Parse(txtInput.Text, CultureInfo.InvariantCulture);
                label1.Visible = true;
            }
            if (memoria == 0)
            {
                label1.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "0" && txtInput.Text.Length > 0)
            {
                memoria -= Double.Parse(txtInput.Text, CultureInfo.InvariantCulture);
                label1.Visible = true;
            }
            if (memoria == 0)
            {
                label1.Visible = false;
            }
        }

        private void frmCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                    vaciarResultado();
                    txtInput.Text += "1";
                    numero = true;
                    break;
                case '2':
                    vaciarResultado();
                    txtInput.Text += "2";
                    numero = true;
                    break;
                case '3':
                    vaciarResultado();
                    txtInput.Text += "3";
                    numero = true;
                    break;
                case '4':
                    vaciarResultado();
                    txtInput.Text += "4";
                    numero = true;
                    break;
                case '5':
                    vaciarResultado();
                    txtInput.Text += "5";
                    numero = true;
                    break;
                case '6':
                    vaciarResultado();
                    txtInput.Text += "6";
                    numero = true;
                    break;
                case '7':
                    vaciarResultado();
                    txtInput.Text += "7";
                    numero = true;
                    break;
                case '8':
                    vaciarResultado();
                    txtInput.Text += "8";
                    numero = true;
                    break;
                case '9':
                    vaciarResultado();
                    txtInput.Text += "9";
                    numero = true;
                    break;
                case '0':
                    vaciarResultado();
                    txtInput.Text += "0";
                    numero = true;
                    break;
                case '+':
                    Sumar();
                    break;
                case '-':
                    Restar();
                    break;
                case '*':
                    Multiplicar();
                    break;
                case '/':
                    Dividir();
                    break;
                case '.':
                    vaciarResultado();
                    txtInput.Text += ".";
                    numero = true;
                    break;
                case (char)Keys.Back:
                    txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1);
                    break;
                case (char)Keys.Enter:
                    Igualar();
                    break;
                default:
                    e.Handled = true;
                    MessageBox.Show("Only numbers, +, -, ., *, / are allowed");
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            unaria = false;
            txtInput.Text = "0";
            txtInput.Focus();
            textBox1.Text = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
            opr1 = 0;
            opr2 = 0;
            operation = "+";
            //initZero = false;
        }

        private void btnSqrRoot_Click(object sender, EventArgs e)
        {
            RaizCuadrada();
        }

        private void btnByTwo_Click(object sender, EventArgs e)
        {
            Inversa();
        }


    }
}
