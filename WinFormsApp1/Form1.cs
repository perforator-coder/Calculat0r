using System.Diagnostics;
using System.Text;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private StringBuilder num1 = new StringBuilder();
        private bool Switch_num = false;
        private StringBuilder Output = new StringBuilder();
        private StringBuilder num2 = new StringBuilder();
        private char select;
        private Form2 ER_form;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Привет я калькулятор \n но очень простой";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string num_button = button.Text;
            if (Switch_num == false)
            {

                num1.Append(num_button);
            }
            else
            {
                num2.Append(num_button);
            }
            Output.Append(num_button);
            label1.Text = Output.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string num_button = button.Text;
            if (Switch_num == false)
            {

                num1.Append(num_button);
            }
            else
            {
                num2.Append(num_button);
            }
            Output.Append(num_button);
            label1.Text = Output.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string num_button = button.Text;
            if (Switch_num == false)
            {

                num1.Append(num_button);
            }
            else
            {
                num2.Append(num_button);
            }
            Output.Append(num_button);
            label1.Text = Output.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string num_button = button.Text;
            if (Switch_num == false)
            {

                num1.Append(num_button);
            }
            else
            {
                num2.Append(num_button);
            }
            Output.Append(num_button);
            label1.Text = Output.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string num_button = button.Text;
            if (Switch_num == false)
            {

                num1.Append(num_button);
            }
            else
            {
                num2.Append(num_button);
            }
            Output.Append(num_button);
            label1.Text = Output.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string num_button = button.Text;
            if (Switch_num == false)
            {

                num1.Append(num_button);
            }
            else
            {
                num2.Append(num_button);
            }
            Output.Append(num_button);
            label1.Text = Output.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string num_button = button.Text;
            if (Switch_num == false)
            {

                num1.Append(num_button);
            }
            else
            {
                num2.Append(num_button);
            }
            Output.Append(num_button);
            label1.Text = Output.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string num_button = button.Text;
            if (Switch_num == false)
            {

                num1.Append(num_button);
            }
            else
            {
                num2.Append(num_button);
            }
            Output.Append(num_button);
            label1.Text = Output.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string num_button = button.Text;
            if (Switch_num == false)
            {

                num1.Append(num_button);
            }
            else
            {
                num2.Append(num_button);
            }
            Output.Append(num_button);
            label1.Text = Output.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string num_button = button.Text;
            if (Switch_num == false)
            {

                num1.Append(num_button);
            }
            else
            {
                num2.Append(num_button);
            }
            Output.Append(num_button);
            label1.Text = Output.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            char char_ = char.Parse(button.Text);
            Output.Append(char_);
            label1.Text = Output.ToString();
            Switch_num = true;
            select = '+';
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Switch_num = false;
            double int_num1 = 0;
            double int_num2 = 0;
            try
            {
                int_num1 = double.Parse(num1.ToString());
                int_num2 = double.Parse(num2.ToString());
            }
            catch (FormatException)
            {
                ER_form = new Form2("ERROR:Переменые не могут быть null");
                ER_form.ShowDialog();

                //num1.Clear();
                //Output.Clear();
                num2.Clear();
                select = ' ';
                Switch_num = false;
                label1.Text = Output.ToString();
            }

            switch (select)
            {
                case ('+'):
                    Output.Clear();
                    num1.Clear();
                    num2.Clear();
                    select = ' ';
                    double result = int_num1 + int_num2;
                    Output.Append(result);
                    num1.Append(result);
                    break;
                case ('-'):
                    Output.Clear();
                    num1.Clear();
                    num2.Clear();
                    select = ' ';
                    double result_min = int_num1 - int_num2;
                    Output.Append(result_min);
                    num1.Append(result_min);
                    break;
                case ('*'):
                    Output.Clear();
                    num1.Clear();
                    num2.Clear();
                    select = ' ';
                    double result_mult = int_num1 * int_num2;
                    Output.Append(result_mult);
                    num1.Append(result_mult);
                    break;
                case ('/'):
                    if (int_num2 == 0.0)
                    {
                        num1.Clear();
                        Output.Clear();
                        num2.Clear();
                        select = ' ';
                        Switch_num = false;
                        label1.Text = Output.ToString();
                        ER_form = new Form2("ERR:Деление на 0 не возможно");
                        ER_form.ShowDialog();
                    }
                    else
                    {
                        Output.Clear();
                        num1.Clear();
                        num2.Clear();
                        select = ' ';
                        double result_dev = int_num1 / int_num2;
                        Output.Append(result_dev);
                        num1.Append(result_dev);
                    }
                    break;
                case ('%'):
                    if (int_num2 == 0.0)
                    {
                        num1.Clear();
                        Output.Clear();
                        num2.Clear();
                        select = ' ';
                        Switch_num = false;
                        label1.Text = Output.ToString();
                        ER_form = new Form2("ERR:Деление % на 0 не возможно");
                        ER_form.ShowDialog();
                    }
                    else
                    {
                        Output.Clear();
                        num1.Clear();
                        num2.Clear();
                        select = ' ';
                        double proc = int_num2 / 100;
                        double result_proc = int_num1 * proc;
                        Output.Append(result_proc);
                        num1.Append(result_proc);
                    }
                    break;
            }
            label1.Text = Output.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num1.Clear();
            Output.Clear();
            num2.Clear();
            select = ' ';
            Switch_num = false;
            label1.Text = Output.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            char char_ = char.Parse(button.Text);
            Output.Append(char_);
            label1.Text = Output.ToString();
            Switch_num = true;
            select = '-';
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            char char_ = char.Parse(button.Text);
            Output.Append(char_);
            label1.Text = Output.ToString();
            Switch_num = true;
            select = '*';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            char char_ = char.Parse(button.Text);
            Output.Append(char_);
            label1.Text = Output.ToString();
            Switch_num = true;
            select = '/';
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Bug Bug_form = new Bug();
            Bug_form.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            char char_ = char.Parse(button.Text);
            Output.Append(char_);
            label1.Text = Output.ToString();
            Switch_num = true;
            select = '%';
        }
    }
}
